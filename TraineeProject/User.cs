using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeProject
{
    internal class User
    {
        delegate void ArrayHandler(User program, MatrixArgs args);
        event ArrayHandler arrayHandler;

        public IOutIn outIn { get; set; }
        public IFiller filler { get; set; }
        public IFinder finder { get; set; }
        public ITranslator translator { get; set; }
        
        public User(IFiller filler, IFinder finder, ITranslator translator, IOutIn outIn)
        {
            arrayHandler += Handle;
            this.outIn = outIn;
            this.finder = finder;
            this.translator = translator;
            this.filler = filler;
        }

        public void Fill() => arrayHandler.Invoke(this, new MatrixArgs(filler.Fill));
        public void Enter() => arrayHandler.Invoke(this, new MatrixArgs(outIn.Enter));
        public void Print() => arrayHandler.Invoke(this, new MatrixArgs(outIn.Print));

        public string Translate() { return translator.LatinConverter(); }
        public int FindMin() { return finder.FindMin(); }
        public int FindMax() { return finder.FindMax(); }

        void Handle(User program, MatrixArgs args)
        {
            try
            {
                args.matrixAct();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}