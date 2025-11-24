#include <mach-o/dyld.h>
#include <dlfcn.h>

namespace x2n_deprecated_api {
	static void* (*run_method)(const void* method, void* obj, void** params, void** exc);
	static void* (*get_method)(void* klass, const char* name, int argsCount);
	static void* (*get_domain)();
	static const void** (*get_assemblies)(const void* domain, size_t* size);
	static const void* (*get_image)(const void* assembly);
	static const void* (*get_class_type)(void* clazz);
	static void* (*class_with_name)(const void* image, const char* namespaze, const char* name);
	static void* (*unbox)(void* obj);
	static void* (*box)(void* clas, void* data);
	static uintptr_t(*new_object)(const void* klass);
	static void* (*new_array)(void* arrayTypeInfo, size_t length);
	static void* (*get_field_from_name)(void* klass, const char* name);
	static void (*static_field_get_value)(void* field, void* value);

	void initialize() {
    	if (!get_field_from_name)
        	*(void**)(&get_field_from_name) = dlsym(RTLD_DEFAULT, ("il2cpp_class_get_field_from_name"));
    	if (!static_field_get_value)
        	*(void**)(&static_field_get_value) = dlsym(RTLD_DEFAULT, ("il2cpp_field_static_get_value"));
    	if (!run_method)
        	*(void**)(&run_method) = dlsym(RTLD_DEFAULT, ("il2cpp_runtime_invoke"));
    	if (!get_method)
        	*(void**)(&get_method) = dlsym(RTLD_DEFAULT, ("il2cpp_class_get_method_from_name"));
    	if (!get_domain)
        	*(void**)(&get_domain) = dlsym(RTLD_DEFAULT, ("il2cpp_domain_get"));
    	if (!get_assemblies)
        	*(void**)(&get_assemblies) = dlsym(RTLD_DEFAULT, ("il2cpp_domain_get_assemblies"));
    	if (!get_image)
        	*(void**)(&get_image) = dlsym(RTLD_DEFAULT, ("il2cpp_assembly_get_image"));
    	if (!class_with_name)
        	*(void**)(&class_with_name) = dlsym(RTLD_DEFAULT, ("il2cpp_class_from_name"));
    	if (!unbox)
        	*(void**)(&unbox) = dlsym(RTLD_DEFAULT, ("il2cpp_object_unbox"));
    	if (!box)
        	*(void**)(&box) = dlsym(RTLD_DEFAULT, ("il2cpp_value_box"));
    	if (!new_object)
        	*(void**)(&new_object) = dlsym(RTLD_DEFAULT, ("il2cpp_object_new"));
	}

	void* get_class(const char* name_space, const char* type_name) {
    	//initialize();
    	void* domik = get_domain();
    	if (!domik) {
        	return nullptr;
    	}
    	size_t asm_count;
    	const void** all = get_assemblies(domik, &asm_count);

    	for (int i = 0; i < asm_count; i++) {
        	const void* ass = all[i];
        	auto img = get_image(ass); //static const void*
        	if (!img) {
            	continue;
        	}
        	auto klass = class_with_name(img, name_space, type_name);
        	if (klass) {
            	return klass;
        	}
    	}
    	return nullptr;
	}
}

void *getStaticField(std::string namespaze, std::string clazz_name,  std::string field_name){
void* clazz = nullptr;
void* field = nullptr;
void* ret = nullptr;
if(!clazz)clazz = x2n_deprecated_api::get_class(namespaze.c_str(), clazz_name.c_str());
if(!field && clazz){field = x2n_deprecated_api::get_field_from_name(clazz, field_name.c_str());
if(!ret && clazz && field){
x2n_deprecated_api::static_field_get_value(field, &ret);
return ret;
}
}
return nullptr;
}
