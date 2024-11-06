**Pre-Employment Test Assignment Steps**

A GUID consists of 32 hexadecimal characters displayed in five groups as 8-4-4-4-12
 (e.g., xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx).
 
**GenerateGUID** class is created within the **Pre.Employment.Test** (not necessary at this point if we have only single file containing all code)

**Random** class object **randomObj**, is declared as static readonly to ensure only one instance is used

List object collects five randomly generated hexadecimal parts using the **GenerateHex** method we can use separate string variable but wo insertion a single List object will work faster

After that’s list items combined using Join function for the sake of display and we can use it as per business requirements.
