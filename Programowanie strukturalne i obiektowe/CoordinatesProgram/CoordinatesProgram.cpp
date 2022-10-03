#include <iostream>

struct Point
{
    int x;
    int y;
    int z;
};

double calculateDistance(int a, int b)
{
    double distance = sqrt(a * a + b * b);
    return distance;
}

double calculateDistance(Point p)
{
    double distance = sqrt(p.x * p.x + p.y * p.y);
    return distance;
}

void CoordinateTestVersion1()
{
    int x, y;
    std::cout << "Podaj x:\n";
    std::cin >> x;

    std::cout << "Podaj y:\n";
    std::cin >> y;

    //double distance = sqrt(x * x + y * y);
    double distance = calculateDistance(x, y);

    std::cout << "Odleglosc to: " << distance << "\n";
}

void CoordinateTestVersion2()
{
    Point userPoint;
    std::cout << "Podaj x:\n";
    std::cin >> userPoint.x;

    std::cout << "Podaj y:\n";
    std::cin >> userPoint.y;

    std::cout << "Podaj z:\n";
    std::cin >> userPoint.z;

    //double distance = sqrt(x * x + y * y);
    double distance = calculateDistance(userPoint.x, userPoint.y);

    std::cout << "Odleglosc to: " << distance << "\n";
}

int main()
{
    system("COLOR E5");
    CoordinateTestVersion2();
}
