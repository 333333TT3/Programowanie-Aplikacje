#include<iostream>

class Point
{
public:

    int x;
    int y;

    double calculateDistance(Point p)
    {
        double distance = sqrt(x * x + y * y);
        return distance;
    }
    
    void SetX(int a)
    {
        if (a >= 0)
            this->x = x;
    }

    void SetY(int a)
    {
        if (a >= 0)
            this->y = y;
    }

    Point()
    {
        x = 0;
        y = 0;
    }

   Point(int x, int y)
    {
        this->x = x;
        this->y = y;
    }

protected:

private:
    
};

int main()
{
    int x;
    std::cout << "Podaj x: \n";
    std::cin >> x;

    int y;
    std::cout << "Podaj y: \n";
    std::cin >> y;

    Point point2;
    Point point(x, y);
   //point.x = 10;
   //point.y = 15; 
   //point.SetX(10);
   //point.SetY(15);
    double distance = point.calculateDistance(point);
    std::cout << "Dystans od punktu (0;0) = " << distance << "\n";
}
