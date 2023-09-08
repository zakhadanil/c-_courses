#define  _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>
#include <iostream>
#include <sstream>
#include <cstring>
using namespace std;

void hello(char *str)
{
	//char const_str[] = "Hello, ";
	//const unsigned int size = sizeof(const_str);
	//str = (char*)realloc(str, (strlen(str) + size)*sizeof(char));
	//strcat(const_str, str);
	//strcpy(str,const_str);
	//memcpy(str, const_str, sizeof(const_str));
	string hello = "Hello, ";
	string world = str;
	string hello_world=hello+world;
	char* str1 = new char[hello_world.length()+1];
	strcpy(str1, hello_world.c_str());
	strcpy(str, str1);
	delete[] str1;
}

int main()
{	
	char *str = _strdup("World!");
	hello(str);
	printf ("%s\n", str);	
	system("pause");	
}