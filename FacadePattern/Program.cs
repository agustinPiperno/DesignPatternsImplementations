using FacadePattern.Interfaces;
using FacadePattern.Entities;

FoodItem burger = new Burger();

IMacroTrackerFacade tracker = new MacroTrackerFacade();
tracker.TrackMacros(burger);
tracker.DisplayTotals();
tracker.TrackMacros(burger);
tracker.DisplayTotals();