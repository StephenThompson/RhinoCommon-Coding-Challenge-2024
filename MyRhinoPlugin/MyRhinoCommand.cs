using Rhino;
using Rhino.Commands;

namespace MyRhinoPlugin
{
    public class MyRhinoCommand : Command
    {
        public MyRhinoCommand()
        {
            // Rhino only creates one instance of each command class defined in a
            // plug-in, so it is safe to store a reference in a static property.
            Instance = this;
        }

        ///<summary>The only instance of this command.</summary>
        public static MyRhinoCommand Instance { get; private set; }

        ///<returns>The command name as it appears on the Rhino command line.</returns>
        public override string EnglishName => "MyRhinoCommand";

        protected override Result RunCommand(RhinoDoc doc, RunMode mode)
        {
            Form1 form = new Form1(doc, mode);
            form.ShowDialog();
            return Result.Success;
        }
    }
}
