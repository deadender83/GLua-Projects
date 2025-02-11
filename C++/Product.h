#include <string>
#include <iostream>
#include <cassert>

using namespace std;

// Sam Cardo
// Specfication File

class Product
{
public:
	Product();
	Product(int /*barcode*/, string /*product name*/);
	virtual ~Product();
	virtual void show(ostream& /*out or output*/);
	virtual void scanner();
	int getBarCode() const { return barCode; }
	string getProductName() const { return *productName; }

protected:
	int barCode;
	string* productName;
};

class PrePackedFood : public Product
{
public:
	PrePackedFood();
	PrePackedFood(int /*bar code*/, string /*product name*/, double /* unit price */);
	void show(ostream& /*out or output*/);
	void scanner();
	double getUnitPrice() const { return unitPrice; }

private:
	double unitPrice;
};


class FreshFood : public Product
{
public:
	FreshFood();
	FreshFood(int /*bar code*/, string /* product name */, double /* unitPrice */, double /* weight */);
	void show(ostream& /*out or output*/);
	void scanner();
	double getUnitPrice() const { return unitPrice; }
	double getWeight() const { return weight; }


private:
	double unitPrice;
	double weight;
};