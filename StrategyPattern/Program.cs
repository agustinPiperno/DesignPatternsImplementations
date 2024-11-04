using StrategyPattern.Entities;
using StrategyPattern.Interfaces;

Workout workout = new Workout();
LinearProgression linearProgression = new LinearProgression();
BenchPress benchPress = new BenchPress(linearProgression);
benchPress.Sets = 3;
benchPress.Reps = 5;
benchPress.Weight = 20;


workout.AddExercise(benchPress);
workout.PerformWorkout();
workout.PerformWorkout();

