using SimpleFactoryPattern.Entities;

ExerciseFactory exerciseFactory = new ExerciseFactory();
Workout workout = new Workout(exerciseFactory);
workout.PerformWorkout(ExerciseFactory.ExerciseType.BenchPress);
workout.PerformWorkout(ExerciseFactory.ExerciseType.Squat);