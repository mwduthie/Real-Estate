# Real-Estate
Part of coursework, using an ObjectFactory and inheritance to build a dictionary of buildings that are either a house or a business

!-==== Executable requires the subfolder data with the realestate.txt file ====-!

We were given a text file with comma seprated lines, for example:

WF4032,Ralston,S,H,115823,1,1,1224
WV5842,Grautan,R,B,1024,wholesale

The in order, reference ID, location, type of transaction, type of building and a value, this is then followed by two variations.
If the building is a house the next values are number of bedrooms, garage capacity and section size.
If the building is a business it is only followed by the type of business.

We were to create an abstract superclass of building and two subclasses for house and business, these had to have a read-only property for each data member. 

The ToString method had to output in a specific format, there had to be a natural sort order based on reference ID as well as another sort order comparing by value (though this wasn't checked by "The Judge" software as we only had to output a single line per user input.

We had to use an object factory to create the buildings, the data for these buildings comes from a text file called realestate.txt. We also were required to have two methods, ReadData (to generate the dictionary) and ProcessRequests (to read user input).

Text prompts have been added in this version, though they would not have worked when submitting.
