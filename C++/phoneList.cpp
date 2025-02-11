#include "phoneList.h"

PhoneList::PhoneList(string name)
{
	title = name;
	numOfDirectories = 0;
	firstPtr = NULL;
}

PhoneList::~PhoneList() 
{
	Directory* walker = firstPtr;

	while (walker != NULL) {
		Directory* builder = walker;
		walker = walker->link;
		delete builder;
	}
	firstPtr = NULL;
}

void PhoneList::showPhoneList(ostream& output) 
{
	output << "My Black Book: " << title << endl;

	if (firstPtr == NULL)
	{
		output << "The List is Empty. No Directories available." << endl;
	}

	output << left << setw(20) << "Name"
		<< setw(10) << "Area Code"
		<< setw(15) << "Phone Number"
		<< endl;

	Directory* walker = firstPtr;
	while (walker != NULL) {
		output << left << setw(20) << walker->name
			<< setw(10) << walker->areaCode
			<< setw(15) << walker->phoneNumber
			<< endl;
		walker = walker->link;
	}

	output << "Number of Directories: " << numOfDirectories << endl;
}

void PhoneList::addDirectory(string name, int areaCode, int phoneNumber) {
	Directory* builder = new Directory;
	assert(builder);
	builder->name = name;
	builder->areaCode = areaCode;
	builder->phoneNumber = phoneNumber;
	builder->link = NULL;

	if (firstPtr == NULL || firstPtr->name > name) {
		builder->link = firstPtr;
		firstPtr = builder;
	}
	else 
	{
		Directory* walker = firstPtr;
		while (walker->link != NULL && walker->link->name < name) 
		{
			walker = walker->link;
		}
		builder->link = walker->link;
		walker->link = builder;
	}

	numOfDirectories++;
	cout << "Added: " << name << endl;
}

void PhoneList::removeDirectory(string name) 
{
	if (firstPtr == NULL) {
		cout << "The directory is empty." << endl;
	}

	Directory* walker = firstPtr;
	Directory* stalker = NULL;

	while (walker != NULL && walker->name != name) {
		stalker = walker;
		walker = walker->link;
	}

	if (walker == NULL) {
		cout << "Name not found in the directory." << endl;
	}

	if (stalker == NULL) {
		firstPtr = walker->link;
	}
	else {
		stalker->link = walker->link;
	}

	delete walker;
	numOfDirectories--;

	cout << "Removed: " << name << endl;
}