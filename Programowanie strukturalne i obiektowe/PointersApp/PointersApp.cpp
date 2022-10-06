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

    //Stos - obszar pamiêci RAM przydzielony naszemu programowi i nie da siê go zwiêkszyæ podczas dzia³ania programu.

    // ta zmienna wyl¹duje na stosie.
    //deklaracja zmiennej o nazwie "number" typu int.
    int number;
    number = 77;
    std::cout << number << "\n";

    //Sterta - pozosta³y wolny obszar pamiêci RAM.

    //delaracja zmiennej lokalnej o nazwie "wsk" która jest wskaŸnikiem na tym int.
    int *wsk;
    //operator "new" rezerwuje obszar dowolnego typu np(int) i zwraca nazwê tego obszaru.
    wsk = new int;
    *wsk = 7;
    //wyœwietlanie adresu pod jakim znajduje siê obszar na stercie.
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