#include <iostream>
#include <string>

using namespace std;

// Sam Cardo
// Specfication File 

const int SIZE = 25;

struct ProductRec
{
    int productCode;
    string description;
    double price;
};

class Inventory
{
public:
    Inventory(const string /* file name */, int = 25 /* max products */);
    void showProduct(int /* product code */) const;
    inline int getNoProducts() const { return noProducts; }
    void increasePrice(int /* product code */, double /* amount of increase */);
    void writeInventory(ostream& /* out file */) const;

private:
    int maxProducts;
    int noProducts = 0; 
    int searchProduct(int /* product code */) const; 
    ProductRec products[SIZE];
};
