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

protected:

private:
    
};

int main()
{
    Point point;
   //point.x = 10;
    //point.y = 15;
    point.SetX(10);
    point.SetY(15);
    double distance = point.calculateDistance(point);
    std::cout << "Dystans od punktu (0:0) = " << distance << "\n";
}
