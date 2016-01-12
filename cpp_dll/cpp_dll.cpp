// cpp_dll.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include "stdio.h"
#include "cpp_dll.h"


MYAPI int Add(int a, int b) {
	int q;

	q = a + b;

	return q;
}


