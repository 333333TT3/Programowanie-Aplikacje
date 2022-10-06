#include <iostream>

int globalVariable = 7;

void AnotherFunction(int parameter)
{
    parameter = 12;
    int anotherLocalVariableFunction = 6;
    globalVariable = 8;
}

void TestFunction()
{
    int localVariableInFunction = 5;
    AnotherFunction(localVariableInFunction);
    globalVariable = 45;
}


int main()
{
    system("cyan");
    /*int localVariableInMain = 8;
    globalVariable = 77;
    TestFunction();*/

    //Stos - obszar pami�ci RAM przydzielony naszemu programowi i nie da si� go zwi�kszy� podczas dzia�ania programu.

    // ta zmienna wyl�duje na stosie.
    //deklaracja zmiennej o nazwie "number" typu int.
    int number;
    number = 77;
    std::cout << number << "\n";

    //Sterta - pozosta�y wolny obszar pami�ci RAM.

    //delaracja zmiennej lokalnej o nazwie "wsk" kt�ra jest wska�nikiem na tym int.
    int *wsk;
    //operator "new" rezerwuje obszar dowolnego typu np(int) i zwraca nazw� tego obszaru.
    wsk = new int;
    *wsk = 7;
    //wy�wietlanie adresu pod jakim znajduje si� obszar na stercie.
    std::cout << wsk << "\n";
    std::cout << *wsk << "\n";

    number = (*wsk) * 2;

    //zwalniamy obszar ze sterty
    delete wsk;
    wsk = NULL;

    //*wsk = 55;
    //std::cout << *wsk << "\n";

    std::cout << "*******************************************\n";

    int tab[3];

    tab[0] = 5;
    *(tab + 0) = 5;

    tab[1] = 15;
    *(tab + 1)=15;

    tab[2] = 15;
    *(tab + 2) = 15;

    std::cout << "Adres zerowego elementu tablicy \t" << tab << "\n";
    std::cout << "Adres pierwszego elementu tablicy \t" << tab + 1 << "\n";

    std::cout << "*******************************************\n";

    int tab2[14];
    const int rozmiar = 5;
   // int tab3[number];
    int tab4[rozmiar];

    int* tab5 = new int[number];
    tab5[7] = 15;
    *(tab5 + 7) = 15;

    delete tab5;

    tab5 = new int[number];

    delete tab5;
}