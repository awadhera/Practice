#define TEST1

#include<iostream>
int main()
{
#ifdef TEST1
	std::cout << "HELLO TEST1";
#endif

#ifdef TEST2
		std::cout << "HELLO TEST2";
#endif

}
