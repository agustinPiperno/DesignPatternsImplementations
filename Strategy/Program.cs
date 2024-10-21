using Strategy.Entities;
using Strategy.Interfaces;

Workout workout = new Workout();
ProgressionStrategy linearProgression = new LinearProgression();
Exercise benchPress = new BenchPress(linearProgression);

workout.AddExercise(benchPress);
workout.PerformWorkout();

