/*----------------------------------------------------
biblioteka do obsługi parsowania plików z google docs
do formatu xml
------------------------------------------------------
*/

// dopiąć biblioteki
using System;
using System.IO;

// wspierane typy plików
#define xlsx 1
#define csv 2

// biblioteki
#include <iostream>
#include <stdlib.h>
#include <stdio.h>
#include <string.h>

// var
std::string readpath;
std::string writepath;

// deklaracje funkcji
void get_readpath();
void set_writepath();
void convert_to_xml(int type, var read=new StreamRead(std::string sciezka));
void store_xml();

// definicje funkcji

// uzyskanie ścieżki
void get_readpath()
{
    std::cin>>readpath;
}

// ścieżka zapisu
void set_writepath()
{
    std::cin>>writepath;
}

// konwersja

// zapis

