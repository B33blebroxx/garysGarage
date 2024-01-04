using Garage;

Zero fxs = new() { Make = "Zero", MainColor = "blue" };
Tesla modelS = new() { Make = "Tesla" };
Cessna mx410 = new();
Ram whatever = new() { MainColor = "black" };

fxs.Drive();
modelS.Turn("left");
mx410.Drive();
fxs.Stop();
modelS.Turn("right");
whatever.Drive();