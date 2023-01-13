/*----------------------------------------------------
biblioteka do obsługi parsowania plików z google docs
do formatu xml
------------------------------------------------------
*/

// plik nagłówkowy
#include "xml.h"
#include <iostream>

int main()
{
    // pobranie ścieżki w której zapisano plik
    std::cout<<"Podaj sciezke w ktorej zapisales plik"<<std::endl;
    get_readpath();
    // pobranie ścieżki do zapisu xml
    std::cout<<"Podaj sciezke w ktorej chcesz zapisac xml"<<std::endl;
    set_writepath();
    std::cout<<"Skonwertuj - podaj typ pierwotny"<<std::endl;
    // konwersja
    convert_to_xml(int type, var read=new StreamRead(std::string sciezka));
    std::cout<<"Zapisywanie"<<std::endl;
    // zapis
    store_xml();    
    return(0);
}