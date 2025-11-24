namespace {
    void *(*il2cpp_assembly_get_image)(void *WFNEFN);
    void *(*il2cpp_domain_get)();
    void *(*il2cpp_thread_attach)(void *ILNI);
    void (*il2cpp_thread_detach)(void *LNKNKL);
    void **(*il2cpp_domain_get_assemblies)(const void *LKNKNLNK, size_t *klKNLN);
    const char *(*il2cpp_image_get_name)(void *KFNEKLQEF);
    void *(*il2cpp_class_from_name)(const void *KLWEFPP, const char *FLKWMFLKWKLKMK, const char *KMLKMKLMMKLMKM);
    void *(*il2cpp_class_get_field_from_name)(void *KLMFKMWLEFMKLLLLW, const char *LKSFV);
    void *(*il2cpp_class_get_method_from_name)(void *KLMFKMWLEFMKLLLLW, const char *LLL, int QPQPQPPQ);
    size_t (*il2cpp_field_get_offset)(void *WEWEW);
    void (*il2cpp_field_static_get_value)(void *WWWEWEWWWWW, void *KLLLLLLLL);
    char *(*il2cpp_type_get_name)(void *MMBMMBMBM);
    void* (*il2cpp_method_get_param)(void *SM, uint32_t MMMMMM);
    void *(*il2cpp_class_get_nested_types)(void *WWWWWWQZZ, void **ZZVVV);
    void* (*il2cpp_class_get_methods)(void *KLMFKMWLEFMKLLLLW, void* *LLLM);
    const char* (*il2cpp_method_get_name)(void *DFS);
    const char *(*il2cpp_class_get_name)(void *WWWWWWQZZ);
}
void Attach();
void *Il2CppGetImageByName(const char *image);
void *Il2CppGetClassType(const char *image, const char *namespaze, const char *clazz);
void Il2CppGetStaticFieldValue(const char *image, const char *namespaze, const char *clazz, const char *name, void *output);

void *Il2CppGetMethodOffset(const char *image, const char *namespaze, const char *clazz, const char *name, int argsCount);
void *Il2CppGetMethodOffset(const char *image, const char *namespaze, const char *clazz, const char *name, char** args, int argsCount);

size_t Il2CppGetFieldOffset(const char *image, const char *namespaze, const char *clazz, const char *name);
