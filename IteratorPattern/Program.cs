using IteratorPattern.Entities;
using IteratorPattern.Interfaces;

Split upperBodySplit = new UpperBodySplit();
Split lowerBodySplit = new LowerBodySplit();

Printer printer = new Printer(upperBodySplit, lowerBodySplit);
printer.PrintExercises();
