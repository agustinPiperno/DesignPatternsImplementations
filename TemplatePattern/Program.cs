using TemplatePattern.Entities;

WorkoutLoader workout1 = new LinearPeriodizationWorkoutLoader();
WorkoutLoader workout2 = new LinearProgressionWorkoutLoader();
workout1.LoadWorkout();
workout2.LoadWorkout();