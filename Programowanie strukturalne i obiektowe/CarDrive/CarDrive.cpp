#include <iostream>

struct CoordinateGPS
{
	int x, y;
};

struct Direction
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
		direction.x = 1;
		direction.y = 0;
	}

	Car(std::string name, int x, int y)
	{
		this->name = name;
		CoordinateGPS.x = 0;
		CoordinateGPS.y = 0;
		direction.x = 1;
		direction.y = 0;
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
	CoordinateGPS.x += direction.x;
	CoordinateGPS.y += direction.y;
}

void TurnLeft()
{
	/*if (direction.x == 1 && direction.y == 0)
	{
		direction.x = 0;
		direction.y = 1;
	}
	else if (direction.x == 0 && direction.y == 1)
	{
		direction.x = -1;
		direction.y = 0;
	}
	else if (direction.x == -1 && direction.y == 0)
	{
		direction.x = 0;
		direction.y = -1;
	}
	else if (direction.x == 0 && direction.y == -1)
	{
		direction.x = 1;
		direction.y = 0;
	}*/

	int tmpX = direction.x;
	direction.x = -direction.y;
	direction.y = tmpX;

}

void TurnRight()
{
	/*if (direction.x == 1 && direction.y == 0)
	{
		direction.x = 0;
		direction.y = -1;
	}
	else if (direction.x == 0 && direction.y == 1)
	{
		direction.x = 1;
		direction.y = 0;
	}
	else if (direction.x == -1 && direction.y == 0)
	{
		direction.x = 0;
		direction.y = 1;
	}
	else if (direction.x == 0 && direction.y == -1)
	{
		direction.x = -1;
		direction.y = 0;
	}*/

	int tmpX = direction.x;
	direction.x = direction.y;
	direction.y = -tmpX;
}

protected:

private:
	std::string name;
	CoordinateGPS CoordinateGPS;

	Direction direction;
};

int main()
{
	Car carFirst("Audi");
	Car carSecond("Volvo",10 ,10);

	carFirst.ShowInfo();
	carSecond.ShowInfo();

	carFirst.MoveForward();
}
