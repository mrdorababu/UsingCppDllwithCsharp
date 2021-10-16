#include <stdexcept>

using namespace std;

namespace CppMathFunctions
{
	extern "C" { __declspec (dllexport) double Add(double a, double b); }
	extern "C" {__declspec (dllexport) double Subtract(double a, double b); }
	extern "C" {__declspec (dllexport) double Multiply(double a, double b); }
	extern "C" {__declspec (dllexport) double Divide(double a, double b); }
}