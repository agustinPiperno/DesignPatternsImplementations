using AdapterPattern.Entities;
using AdapterPattern.Interfaces;

MainApp mainApp = new MainApp();

ThirdPartyApp thirdPartyApp = new ThirdPartyApp();
MacroService thirdPartyMacroServiceAdapter = new ThirdPartyMacroServiceAdapter(thirdPartyApp);

Console.WriteLine(thirdPartyMacroServiceAdapter.Protein);
Console.WriteLine(thirdPartyMacroServiceAdapter.Carbs);
Console.WriteLine(thirdPartyMacroServiceAdapter.Fat);
Console.WriteLine(thirdPartyMacroServiceAdapter.Calories);

