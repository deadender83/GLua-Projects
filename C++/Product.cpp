#include "Product.h"

// Sam Cardo
// Impletation File

Product::Product()
{
	cout << "Enter barcode: ";
	cin >> barCode;
	barCode = (barCode >= 0) ? barCode : 0;

	cout << "Enter product name: ";
	string name;
	cin.ignore();
	getline(cin, name);

	productName = new string(name.length() == 0 ? "No Name" : name);
	assert(productName != NULL);
}

Product::Product(int newBarCode, string newProductName)
{
	productName = new string(newProductName.length() == 0 ? "No Name" : newProductName);
	barCode = (newBarCode >= 0) ? newBarCode : 0;
	assert(productName != NULL);
}

Product::~Product()
{
	cout << "inside product deconstrutor";
	delete productName;
}

void Product::show(ostream& out)
{
	out << "Product Barcode: " << barCode << ", Product Name: " << *productName << endl;
	Product::scanner();
}

void Product::scanner()
{
	int cents = barCode * 100;
	if (barCode % 2 == 0 || cents % 100 == 99)
		cout << "Discounted!" << endl;
}

PrePackedFood::PrePackedFood(int newBarCode, string newProductName , double newUnitPrice)
{
	productName = new string(newProductName.length() == 0 ? "No Name" : newProductName);
	barCode = (newBarCode >= 0) ? newBarCode : 0;
	assert(productName != NULL);

	unitPrice = (newUnitPrice >= 0.0) ? newUnitPrice : 0.0;
}

PrePackedFood::PrePackedFood()
{
	cout << "Enter barcode: ";
	cin >> barCode;
	barCode = (barCode >= 0) ? barCode : 0;

	cout << "Enter product name: ";
	string name;
	cin.ignore();
	getline(cin, name);

	productName = new string(name.length() == 0 ? "No Name" : name);
	assert(productName != NULL);

	cout << "Enter Unit Price";
	cin >> unitPrice;
	unitPrice = (unitPrice >= 0) ? unitPrice : 0;
}

void PrePackedFood::show(ostream& out)
{
	out << "PrePacked Food Barcode: " << barCode << ", Product Name: "
		<< *productName << ", Unit Price: $" << unitPrice << endl;

	PrePackedFood::scanner();
}

void PrePackedFood::scanner()
{
	int cents = barCode * 100 + 0.5;

	if (barCode % 2 == 0 || cents  % 100 == 99)
	{
		cout << "Discounted!";
	}
}

FreshFood::FreshFood(int newBarCode, string newProductName, double newUnitPrice, double newWeight)
{
	productName = new string(newProductName.length() == 0 ? "No Name" : newProductName);
	barCode = (newBarCode >= 0) ? newBarCode : 0;
	assert(productName != NULL);

	unitPrice = (newUnitPrice >= 0.0) ? newUnitPrice : 0.0;
	weight = (newWeight >= 0.0) ? newWeight : 0.0;
}

FreshFood::FreshFood()
{
	cout << "Enter barcode: ";
	cin >> barCode;
	barCode = (barCode >= 0) ? barCode : 0;

	cout << "Enter product name: ";
	string name;
	cin.ignore();
	getline(cin, name);

	productName = new string(name.length() == 0 ? "No Name" : name);
	assert(productName != NULL);

	cout << "Enter Unit Price";
	cin >> unitPrice;
	unitPrice = (unitPrice >= 0) ? unitPrice : 0;

	cout << "Enter Weight";
	cin >> weight;
	weight = (weight >= 0) ? weight : 0;
}

void FreshFood::show(ostream& out)
{
	out << "Fresh Food Barcode: " << barCode << ", Product Name: " << *productName
		<< ", Unit Price: $" << unitPrice << ", Weight: " << weight << "Ibs" << endl;
	FreshFood::scanner();
}

void FreshFood::scanner()
{
	int cents = unitPrice * 100 + 0.5;
	if (barCode % 2 == 0 || cents % 100 == 99) 
	{
		cout << "Discounted!" << endl;
	}

}