#include <mach-o/dyld.h>
#include <map>

template <typename T>
struct monoArray {
    void *klass;
    void *monitor;
    void *bounds;
    int32_t capacity;
    T m_Items[0];
    [[maybe_unused]] int32_t getCapacity() {
        return capacity;
    }
    T *getPointer() {
        return m_Items;
    }
    std::vector<T> toCPPlist() {
        std::vector<T> ret;
        for (int i = 0; i < capacity; i++) ret.push_back(m_Items[i]);
        return std::move(ret);
    }
    bool copyFrom(const std::vector<T> &vec) {
        return copyFrom((T *)vec.data(), (int)vec.size());
    }
    [[maybe_unused]] bool copyFrom(T *arr, int size) {
        if(size < capacity) return false;
        memcpy(m_Items, arr, size * sizeof(T));
        return true;
    }
    [[maybe_unused]] void copyTo(T *arr) {
        if(!CheckObj(m_Items)) return;
        memcpy(arr, m_Items, sizeof(T) * capacity);
    }
    T &operator[](int index) {
        if(getCapacity() < index) {
            T a{};
            return a;
        }
        return m_Items[index];
    }
    const T at(int index) {
        if(getCapacity() <= index || empty()) {
            T a{};
            return a;
        }
        return m_Items[index];
    }
    bool empty() {
        return getCapacity() <= 0;
    }
    static monoArray<T> *Create(int capacity) {
        auto monoArr = (monoArray<T> *)malloc(sizeof(monoArray) + sizeof(T) * capacity);
        monoArr->capacity = capacity;
        return monoArr;
    }
    [[maybe_unused]] static monoArray<T> *Create(const std::vector<T> &vec) { return Create(vec.data(), vec.size()); }
    static monoArray<T> *Create(T *arr, int size) {
        monoArray<T> *monoArr = Create(size);
        monoArr->copyFrom(arr, size);
        return monoArr;
    }
};

typedef struct _monoString {
    void *klass;
    void *monitor;
    int length;
    char chars[1];

    int getLength() { return length; }
    char *getChars() { return chars; }
    NSString *toNSString() { return [[NSString alloc] initWithBytes:(const void *)(chars) length:(NSUInteger)(length * 2) encoding:(NSStringEncoding)NSUTF16LittleEndianStringEncoding]; }
    char *toCString() { return (char *)(toNSString().UTF8String); }
    std::string toCPPString() { return std::string(toCString()); }
} monoString;

/*static monoString *il2cpp_string_new(const char *str) {
    static monoString *(*String_CreateString)(void *instance, const char *str, int start, int len) = (monoString * (*)(void *, const char *, int, int)) getRealOffset(ENCRYPTOFFSET("0x2A23334"));
    return String_CreateString(nullptr, str, 0, strlen(str));
}*/

template <typename T>
struct monoList {
    void *unk0;
    void *unk1;
    monoArray<T> *items;
    int size;
    int version;

    T getItems() { return items->getPointer(); }
    int getSize() { return size; }
    int getVersion() { return version; }
};

template <typename TKey, typename TValue>
struct [[maybe_unused]] monoDictionary {
    struct Entry {
        [[maybe_unused]] int hashCode, next;
        TKey key;
        TValue value;
    };
    void *klass;
    void *monitor;
    [[maybe_unused]] monoArray<int> *buckets;
    monoArray<Entry> *entries;
    int count;
    int version;
    [[maybe_unused]] int freeList;
    [[maybe_unused]] int freeCount;
    [[maybe_unused]] void *comparer;
    monoArray<TKey> *keys;
    monoArray<TValue> *values;
    [[maybe_unused]] void *syncRoot;
    std::map<TKey, TValue> toMap() {
        std::map<TKey, TValue> ret;
        for (auto it = (Entry *)&entries->m_Items; it != ((Entry *)&entries->m_Items + count); ++it) ret.emplace(std::make_pair(it->key, it->value));
        return std::move(ret);
    }
    std::vector<TKey> getKeys() {
        std::vector<TKey> ret;
        for (int i = 0; i < count; ++i) ret.emplace_back(entries->at(i).key);
        return std::move(ret);
    }
    std::vector<TValue> getValues() {
        std::vector<TValue> ret;
        for (int i = 0; i < count; ++i) ret.emplace_back(entries->at(i).value);
        return std::move(ret);
    }
    int getSize() { return count; }
    [[maybe_unused]] int getVersion() { return version; }
    TValue Get(TKey key) {
        TValue ret;
        if (TryGet(key, ret)) return ret;
        return {};
    }
    TValue operator[](TKey key) { return Get(key); }
};

union intfloat {
	int i;
	float f;
};

/*
Get the real value of an ObscuredInt.
Parameters:
	- location: the location of the ObscuredInt
*/
int GetObscuredIntValue(uint64_t location){
	int cryptoKey = *(int *)location;
	int obfuscatedValue = *(int *)(location + 0x4);
	
	return obfuscatedValue ^ cryptoKey;
}

int GetObscuredBoolValue(uint64_t location){
	int cryptoKey = *(int *)(location + 0x8);
	int obfuscatedValue = *(int *)(location + 0xC);
	obfuscatedValue ^= cryptoKey;
	return obfuscatedValue;
}

/*
Set the real value of an ObscuredInt.
Parameters:
	- location: the location of the ObscuredInt
	- value: the value we're setting the ObscuredInt to
*/
void SetObscuredIntValue(uint64_t location, int value){
	int cryptoKey = *(int *)location;
	
	*(int *)(location + 0x4) = value ^ cryptoKey;
}

/*
Get the real value of an ObscuredFloat.
Parameters:
	- location: the location of the ObscuredFloat
*/
float GetObscuredFloatValue(uint64_t location){
	int cryptoKey = *(int *)location;
	int obfuscatedValue = *(int *)(location + 0x4);
	
	/* use this intfloat to set the integer representation of our parameter value, which will also set the float value */
	intfloat IF;
	IF.i = obfuscatedValue ^ cryptoKey;
	
	return IF.f;
}

/*
Set the real value of an ObscuredFloat.
Parameters:
	- location: the location of the ObscuredFloat
	- value: the value we're setting the ObscuredFloat to
*/
void SetObscuredFloatValue(uint64_t location, float value){
	int cryptoKey = *(int *)location;

	/* use this intfloat to get the integer representation of our parameter value */
	intfloat IF;
	IF.f = value;
	
	/* use this intfloat to generate our hacked ObscuredFloat */
	intfloat IF2;
	IF2.i = IF.i ^ cryptoKey;
	
	*(float *)(location + 0x4) = IF2.f;
}
