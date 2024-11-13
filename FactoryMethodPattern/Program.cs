using FactoryMethodPattern.Entities;

Workout upperBodyWorkout = new UpperBodyWorkout();
Workout lowerBodyWorkout = new LowerBodyWorkout();

upperBodyWorkout.PerformWorkout(Workout.ExerciseType.BenchPress);
lowerBodyWorkout.PerformWorkout(Workout.ExerciseType.Squat);
lowerBodyWorkout.PerformWorkout(Workout.ExerciseType.BenchPress);
lowerBodyWorkout.PerformWorkout(Workout.ExerciseType.Deadlift);