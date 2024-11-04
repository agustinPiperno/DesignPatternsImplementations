using ObserverPattern.Entities;

ExerciseData exerciseData = new ExerciseData();
ProgressionDisplay progressionDisplay = new ProgressionDisplay(exerciseData);
Estimated1RMDisplay estimated1RMDisplay = new Estimated1RMDisplay(exerciseData);

exerciseData.setMeasurements(85, 5);
exerciseData.removeObserver(progressionDisplay);
exerciseData.setMeasurements(90, 4);
exerciseData.registerObserver(progressionDisplay);
exerciseData.setMeasurements(100, 2);
