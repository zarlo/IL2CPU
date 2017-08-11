
using XSharp;

namespace Cosmos.IL2CPU.X86.IL
{
    [OpCode(ILOpCode.Code.Br)]
    public class Br : ILOp
    {
        public Br(XSharp.Assembler.Assembler aAsmblr)
            : base(aAsmblr)
        {
        }

        public override void Execute(_MethodInfo aMethod, ILOpCode aOpCode)
        {
            XS.Jump(AppAssembler.TmpBranchLabel(aMethod, aOpCode));
            //new CPU.Jump { DestinationLabel = AppAssembler.TmpBranchLabel(aMethod, aOpCode) };

    }
  }
}
