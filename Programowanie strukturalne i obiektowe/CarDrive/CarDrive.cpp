#include <iostream>

struct CoordinateGPS
{
	int x, y;
};

class Car
{

public:
	Car(std::string name)
	{
		this->name = name;
		CoordinateGPS.x = 0;
		CoordinateGPS.y = 0;
		directionX = 1;
		directionY = 0;
	}

	Car(std::string name, int x, int y)
	{
		this->name = name;
		CoordinateGPS.x = 0;
		CoordinateGPS.y = 0;
		directionX = 1;
		directionY = 0;
	}

	void ShowInfo()
	{
		std::cout << "********************************************\n";
		std::cout << "Samochod o nazwie: " << name << "\n";
		std::cout << "Pozycja (" << CoordinateGPS.x << " ; " << CoordinateGPS.y << ")\n";
		std::cout << "********************************************\n";
	}

void MoveForward()
{
	CoordinateGPS.x += directionX;
	CoordinateGPS.y += directionY;
}

protected:


private:
	std::string name;
	CoordinateGPS CoordinateGPS;

	int directionX, directionY;
};

int main()
{
	Car carFirst("Audi");
	Car carSecond("Volvo",10 ,10);

	carFirst.ShowInfo();
	carSecond.ShowInfo();

	carFirst.MoveForward();
}
