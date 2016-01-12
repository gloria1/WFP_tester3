#ifndef _CPP_DLL_H_
#define _CPP_DLL_H_

#ifndef MYAPI
#define MYAPI __declspec(dllexport)
#endif

#ifdef __cplusplus
extern "C" {
#endif

	// Exported functions go here.
	MYAPI int Add(int a, int b);

#ifdef __cplusplus
}
#endif

#endif // _NATIVELIB_H_
