The Financial officer at RGIT wants you to develop an application that will evaluate the company’s asset’s annual depreciation using the double-declining balance and sum-of-the years’ digit method.

    The Financial officer will enter the asset’s cost, useful life (in years), and salvage value (which is the value of the asset at the end of its useful life).
    The sample of the application can be seen in Figure 2. The interface provides text boxes for entering the asset cost and salvage value. 
    It also provides a list box for selecting the useful life, which ranges from 3 to 20 years. 
    The depreciation amounts are displayed in the list boxes. (You can use the DDB and SYD functions in Microsoft Excel to verify the amounts shown in Figure 2 are correct). 
    Create a windows form application using the name RGIT annual asset depreciation App. You can use the visual basic’s Financial.DDB method to calculate the double-declining balance depreciation and use its Financial.SYD method to calculate the sum-of-the-years’ digit depreciation. 
    The Financial.DDB method syntax is Financial.DDB (cost, salvage, life, period). 
    The Financial.SYD method syntax is Financial.SYD (cost, salvage, life, period). 
    In both syntaxes, the cost, salvage and life arguments are the asset’s cost, salvage value and useful life respectively. The period argument is the period for which you want the depreciation amount calculated. 
    Both methods return the depreciation amount as double number. Code the application, save the solution and run the application