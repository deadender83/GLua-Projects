#include "Inventory.h"
#include <iostream>
#include <string>
#include <iomanip>
#include <fstream>

using namespace std;

//Sam Cardo
// Implementation File this file defines all of the function that the client code will use

Inventory::Inventory(const string filename, int initialMaxProducts)
{
	ifstream fin(filename);
	if (!fin.is_open())
	{
		cout << "Error opening file " << endl;
		system("pause");
		exit(-1);
	}
	
	noProducts = 0;

	for (int index = 0; index < SIZE; index++)
	{
		fin >> products[index].productCode; 

		if (fin.eof()) 
		break; 

		fin.ignore();
		getline(fin, products[index].description);
		fin >> products[index].price; 


		noProducts++; 
	}

	if (initialMaxProducts > SIZE || initialMaxProducts <= 0)
	{
		cout << "Invalid number of products, assigning default value: " << SIZE << endl;
		maxProducts = SIZE;
	}
	else
	{
		maxProducts = initialMaxProducts;
	}

	fin.close();
}


int Inventory::searchProduct(int productCode) const 
{
	for (int index = 0; index < noProducts; index++) 
	{
		if (products[index].productCode == productCode) 
		{
			return index;
		}
	}
	return noProducts;
}

void Inventory::showProduct(int productCode) const 
{
	int position = searchProduct(productCode);

	if (position < noProducts) 
	{
		cout << "Product Code: " << products[position].productCode << endl;
		cout << "Description: " << products[position].description << endl;
		cout << "Price: $" << fixed << setprecision(2) << products[position].price << endl;
	}
	else {
		cout << "Error: Product not found!" << endl;
	}
}

void Inventory::increasePrice(int productCode, double increaseOfPrice)
{
	int position = searchProduct(productCode);

	if (position == noProducts)
	{
		cout << "Error: Product Doesn't Exist!" << endl;
		return;
	}

	products[position].price += increaseOfPrice; 

	if (products[position].price > 1000)
	{
		products[position].price = 1000;
		cout << "Price for product code " << productCode << " set to maximum $1000." << endl;
	}
}


void Inventory::writeInventory(ostream& out) const
{
	out << setw(10) << "Code" << setw(20) << "Description" << setw(10) << "Price" << endl;

	for (int ctr = 0; ctr < noProducts; ctr++) 
	{
		out << setw(10) << products[ctr].productCode
			<< setw(20) << products[ctr].description
			<< setw(10) << fixed << setprecision(2) << products[ctr].price
			<< endl;
	}

	out << "Total products: " << noProducts << endl;
}





