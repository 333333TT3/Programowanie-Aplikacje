#include <iostream>
#include<ctime>

/*Napisaæ klasê(oraz kod testuj¹cy)opisuj¹c¹ osobê.
Dodaæ 5 pól opisuj¹cych osobê (ma byæ rok urodzenia).
Dodanie konstruktorów umo¿liwiaj¹cych utworzenie obiektu na kilka sposobów.
Metoda która wyœwietli informacje o osobie.
Metoda która wyœwietli czy osoba jest pe³noletnia czy nie.*/

class Pearson
{
public:
    Pearson()
    {
        name = "x";
        surname = "y";
        heigth = 170;
        weigth = 60;
        time_t now = time(0);
        tm* ltm = new tm;
        localtime_s(ltm, &now);
        yearOfBirth = 1900 + ltm->tm_year;
    }

    void BusinessCard()
    {
        std::cout << "*********************************************************\n";
        std::cout << "Imie: (" << name << " Nazwisko: " << surname << ")\n";
        std::cout << "Wzrost: (" << heigth << " Waga: " << weigth << ")\n";
        std::cout << "Wiek " << adult << "\n";
        std::cout << "*********************************************************\n";
    }

private:
    std::string name;
    std::string surname;
    int heigth;
    int weigth;
    int yearOfBirth;
protected:
};

int main()
{

    time_t now = time(0);
    tm* ltm = new tm;
    localtime_s(ltm, &now);
    bool adult = 1900 + ltm->tm_year;


    std::string name;
    std::string surname;
    int heigth;
    int weigth;
    int DateOfBirth;

    std::cout << "Podaj imie: ";
    std::cin >> name;
    std::cout << "Podaj nazwisko: ";
    std::cin >> surname;
    std::cout << "Podaj wzrost: ";
    std::cin >> heigth;
    std::cout << "Podaj wage (kg):  ";
    std::cin >> weigth;
    std::cout << "Podaj rok urodzenia: ";
    std::cin >> DateOfBirth;

    time_t now = time(0);

    std::cout << "Number of second since January 1st 1970 is: "
        << now << std::endl;

    tm* ltm = new tm;
    localtime_s(ltm, &now);

    std::cout << "Year:" << 1900 + ltm->tm_year << std::endl;
    std::cout << "Month: " << 1 + ltm->tm_mon << std::endl;
    std::cout << "Day: " << ltm->tm_mday << std::endl;
    std::cout << "Time: ";
    std::cout << ltm->tm_hour << ":";
    std::cout << ltm->tm_min << ":";
    std::cout << ltm->tm_sec << std::endl;
    delete ltm;
}
