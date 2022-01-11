using TraineeProject;

var type = new MatrixType();
var finder = new MatrixFinder();
var filler = new MatrixFiller();
var io = new MatrixIO();
var translator = new Translator();

finder.args = type;
filler.args = type;
io.args = type;
translator.args = type;

var program = new User(filler, finder, translator, io);
var valueIO = new ValueIo<int>();

program.Enter();
program.Fill();
program.Print();

program.outIn = valueIO;
valueIO.value = program.FindMax();
program.Print();
valueIO.value = program.FindMin();
program.Print();


var stringOut = new ValueIo<string>();
program.outIn = stringOut;
stringOut.value = program.Translate();
program.Print();