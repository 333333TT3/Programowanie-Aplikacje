#include <iostream>
#include<ctime>

/*Napisa� klas�(oraz kod testuj�cy)opisuj�c� osob�.
Doda� 5 p�l opisuj�cych osob� (ma by� rok urodzenia).
Dodanie konstruktor�w umo�liwiaj�cych utworzenie obiektu na kilka sposob�w.
Metoda kt�ra wy�wietli informacje o osobie.
Metoda kt�ra wy�wietli czy osoba jest pe�noletnia czy nie.*/

class Person
{
public:
    Person()
    {
        name = "Pawel";
        surname = "Nowak";
        heigth = 172;
        weigth = 60;
        time_t now = time(0);
        tm* ltm = new tm;
        localtime_s(ltm, &now);
        yearOfBirth = 1900 + ltm->tm_year;
    }

    int firstPerson()
    {
        std::string name;
        std::string surname;
        int age;
        int heigth;
        int weigth;
        int yearOfBirth;
    }

    void BusinessCard()
    {
        time_t now = time(0);
        tm* ltm = new tm;
        localtime_s(ltm, &now);
        //yearOfBirth = 1900 + ltm->tm_year;

        std::cout << "**********************************************************\n";
        std::cout << "(""Imie: " << name << " Nazwisko: " << surname << ")\n";
        std::cout << "(""Wzrost: " << heigth << " Waga: " << weigth << ")\n";
        std::cout << "Wiek " << &now <<"\n";
        std::cout << "**********************************************************\n";
        std::cout << "\n";
    }

    void LegalAge()
    {
        int age;

        time_t now = time(0);
        tm* ltm = new tm;
        localtime_s(ltm, &now);

        age = 1900 + ltm->tm_year - yearOfBirth;

        std::cout << "**********************************************************\n";
        if (age < 18)
        {
            std::cout << "Osoba jest pelnoletnia";
            std::cout << "\n";
        }
        else
            std::cout << "Osoba jest niepelnoletnia\n";
        std::cout << "**********************************************************\n";
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
    Person firstPerson;
    firstPerson.BusinessCard();
    firstPerson.LegalAge();

/*std::string name;
std::string surname;
int age;
int heigth;
int weigth;
int DateOfBirth;


    if (age > 18)
    {
        std::cout << "Osoba jest pelnoletnia";
    }
    else
    {
        std::cout << "Osoba jest niepelnoletnia";
    }

    time_t now = time(0);
    tm* ltm = new tm;
    localtime_s(ltm, &now);
    bool adult = 1900 + ltm->tm_year;

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

    now = time(0);

    std::cout << "Number of second since January 1st 1970 is: "
        << now << std::endl;

    ltm = new tm;
    localtime_s(ltm, &now);

    std::cout << "Year:" << 1900 + ltm->tm_year << std::endl;
    std::cout << "Month: " << 1 + ltm->tm_mon << std::endl;
    std::cout << "Day: " << ltm->tm_mday << std::endl;
    std::cout << "Time: ";
    std::cout << ltm->tm_hour << ":";
    std::cout << ltm->tm_min << ":";
    std::cout << ltm->tm_sec << std::endl;
    delete ltm;
    */
}
