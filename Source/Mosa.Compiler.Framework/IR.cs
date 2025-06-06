// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework.Instructions;

namespace Mosa.Compiler.Framework;

/// <summary>
/// IR Instructions
/// </summary>
public static class IR
{
	public static readonly BaseInstruction AddR4 = new AddR4();
	public static readonly BaseInstruction AddR8 = new AddR8();
	public static readonly BaseInstruction AddressOf = new AddressOf();
	public static readonly BaseInstruction Add32 = new Add32();
	public static readonly BaseInstruction Add64 = new Add64();
	public static readonly BaseInstruction AddManagedPointer = new AddManagedPointer();
	public static readonly BaseInstruction AddCarryOut32 = new AddCarryOut32();
	public static readonly BaseInstruction AddCarryOut64 = new AddCarryOut64();
	public static readonly BaseInstruction AddCarryIn32 = new AddCarryIn32();
	public static readonly BaseInstruction AddCarryIn64 = new AddCarryIn64();
	public static readonly BaseInstruction AddOverflowOut32 = new AddOverflowOut32();
	public static readonly BaseInstruction AddOverflowOut64 = new AddOverflowOut64();
	public static readonly BaseInstruction ArithShiftRight32 = new ArithShiftRight32();
	public static readonly BaseInstruction ArithShiftRight64 = new ArithShiftRight64();
	public static readonly BaseInstruction BlockEnd = new BlockEnd();
	public static readonly BaseInstruction BlockStart = new BlockStart();
	public static readonly BaseInstruction Call = new Call();
	public static readonly BaseInstruction CallDirect = new CallDirect();
	public static readonly BaseInstruction CallDynamic = new CallDynamic();
	public static readonly BaseInstruction CallInterface = new CallInterface();
	public static readonly BaseInstruction CallStatic = new CallStatic();
	public static readonly BaseInstruction CallVirtual = new CallVirtual();
	public static readonly BaseInstruction CompareR4 = new CompareR4();
	public static readonly BaseInstruction CompareR8 = new CompareR8();
	public static readonly BaseInstruction CompareObject = new CompareObject();
	public static readonly BaseInstruction CompareManagedPointer = new CompareManagedPointer();
	public static readonly BaseInstruction Compare32x32 = new Compare32x32();
	public static readonly BaseInstruction Compare32x64 = new Compare32x64();
	public static readonly BaseInstruction Compare64x32 = new Compare64x32();
	public static readonly BaseInstruction Compare64x64 = new Compare64x64();
	public static readonly BaseInstruction Branch32 = new Branch32();
	public static readonly BaseInstruction Branch64 = new Branch64();
	public static readonly BaseInstruction BranchObject = new BranchObject();
	public static readonly BaseInstruction BranchManagedPointer = new BranchManagedPointer();
	public static readonly BaseInstruction ConvertR4ToR8 = new ConvertR4ToR8();
	public static readonly BaseInstruction ConvertR4ToI32 = new ConvertR4ToI32();
	public static readonly BaseInstruction ConvertR4ToI64 = new ConvertR4ToI64();
	public static readonly BaseInstruction ConvertR8ToR4 = new ConvertR8ToR4();
	public static readonly BaseInstruction ConvertR8ToI32 = new ConvertR8ToI32();
	public static readonly BaseInstruction ConvertR8ToI64 = new ConvertR8ToI64();
	public static readonly BaseInstruction ConvertI32ToR4 = new ConvertI32ToR4();
	public static readonly BaseInstruction ConvertI64ToR4 = new ConvertI64ToR4();
	public static readonly BaseInstruction ConvertI32ToR8 = new ConvertI32ToR8();
	public static readonly BaseInstruction ConvertI64ToR8 = new ConvertI64ToR8();
	public static readonly BaseInstruction ConvertR4ToU32 = new ConvertR4ToU32();
	public static readonly BaseInstruction ConvertR4ToU64 = new ConvertR4ToU64();
	public static readonly BaseInstruction ConvertR8ToU32 = new ConvertR8ToU32();
	public static readonly BaseInstruction ConvertR8ToU64 = new ConvertR8ToU64();
	public static readonly BaseInstruction ConvertU32ToR4 = new ConvertU32ToR4();
	public static readonly BaseInstruction ConvertU64ToR4 = new ConvertU64ToR4();
	public static readonly BaseInstruction ConvertU32ToR8 = new ConvertU32ToR8();
	public static readonly BaseInstruction ConvertU64ToR8 = new ConvertU64ToR8();
	public static readonly BaseInstruction DivR4 = new DivR4();
	public static readonly BaseInstruction DivR8 = new DivR8();
	public static readonly BaseInstruction DivSigned32 = new DivSigned32();
	public static readonly BaseInstruction DivSigned64 = new DivSigned64();
	public static readonly BaseInstruction DivUnsigned32 = new DivUnsigned32();
	public static readonly BaseInstruction DivUnsigned64 = new DivUnsigned64();
	public static readonly BaseInstruction Epilogue = new Epilogue();
	public static readonly BaseInstruction ExceptionEnd = new ExceptionEnd();
	public static readonly BaseInstruction ExceptionStart = new ExceptionStart();
	public static readonly BaseInstruction FilterEnd = new FilterEnd();
	public static readonly BaseInstruction FilterStart = new FilterStart();
	public static readonly BaseInstruction FinallyEnd = new FinallyEnd();
	public static readonly BaseInstruction FinallyStart = new FinallyStart();
	public static readonly BaseInstruction Flow = new Flow();
	public static readonly BaseInstruction Gen = new Gen();
	public static readonly BaseInstruction Use = new Use();
	public static readonly BaseInstruction IntrinsicMethodCall = new IntrinsicMethodCall();
	public static readonly BaseInstruction IsInstanceOfType = new IsInstanceOfType();
	public static readonly BaseInstruction IsInstanceOfInterfaceType = new IsInstanceOfInterfaceType();
	public static readonly BaseInstruction Jmp = new Jmp();
	public static readonly BaseInstruction Kill = new Kill();
	public static readonly BaseInstruction KillAll = new KillAll();
	public static readonly BaseInstruction KillAllExcept = new KillAllExcept();
	public static readonly BaseInstruction LoadCompound = new LoadCompound();
	public static readonly BaseInstruction LoadR4 = new LoadR4();
	public static readonly BaseInstruction LoadR8 = new LoadR8();
	public static readonly BaseInstruction Load32 = new Load32();
	public static readonly BaseInstruction Load64 = new Load64();
	public static readonly BaseInstruction LoadObject = new LoadObject();
	public static readonly BaseInstruction LoadManagedPointer = new LoadManagedPointer();
	public static readonly BaseInstruction LoadSignExtend8x32 = new LoadSignExtend8x32();
	public static readonly BaseInstruction LoadSignExtend16x32 = new LoadSignExtend16x32();
	public static readonly BaseInstruction LoadSignExtend8x64 = new LoadSignExtend8x64();
	public static readonly BaseInstruction LoadSignExtend16x64 = new LoadSignExtend16x64();
	public static readonly BaseInstruction LoadSignExtend32x64 = new LoadSignExtend32x64();
	public static readonly BaseInstruction LoadZeroExtend8x32 = new LoadZeroExtend8x32();
	public static readonly BaseInstruction LoadZeroExtend16x32 = new LoadZeroExtend16x32();
	public static readonly BaseInstruction LoadZeroExtend8x64 = new LoadZeroExtend8x64();
	public static readonly BaseInstruction LoadZeroExtend16x64 = new LoadZeroExtend16x64();
	public static readonly BaseInstruction LoadZeroExtend32x64 = new LoadZeroExtend32x64();
	public static readonly BaseInstruction LoadParamCompound = new LoadParamCompound();
	public static readonly BaseInstruction LoadParamObject = new LoadParamObject();
	public static readonly BaseInstruction LoadParamManagedPointer = new LoadParamManagedPointer();
	public static readonly BaseInstruction LoadParamR4 = new LoadParamR4();
	public static readonly BaseInstruction LoadParamR8 = new LoadParamR8();
	public static readonly BaseInstruction LoadParam32 = new LoadParam32();
	public static readonly BaseInstruction LoadParam64 = new LoadParam64();
	public static readonly BaseInstruction LoadParamSignExtend8x32 = new LoadParamSignExtend8x32();
	public static readonly BaseInstruction LoadParamSignExtend16x32 = new LoadParamSignExtend16x32();
	public static readonly BaseInstruction LoadParamSignExtend8x64 = new LoadParamSignExtend8x64();
	public static readonly BaseInstruction LoadParamSignExtend16x64 = new LoadParamSignExtend16x64();
	public static readonly BaseInstruction LoadParamSignExtend32x64 = new LoadParamSignExtend32x64();
	public static readonly BaseInstruction LoadParamZeroExtend8x32 = new LoadParamZeroExtend8x32();
	public static readonly BaseInstruction LoadParamZeroExtend16x32 = new LoadParamZeroExtend16x32();
	public static readonly BaseInstruction LoadParamZeroExtend8x64 = new LoadParamZeroExtend8x64();
	public static readonly BaseInstruction LoadParamZeroExtend16x64 = new LoadParamZeroExtend16x64();
	public static readonly BaseInstruction LoadParamZeroExtend32x64 = new LoadParamZeroExtend32x64();
	public static readonly BaseInstruction And32 = new And32();
	public static readonly BaseInstruction And64 = new And64();
	public static readonly BaseInstruction Not32 = new Not32();
	public static readonly BaseInstruction Not64 = new Not64();
	public static readonly BaseInstruction Or32 = new Or32();
	public static readonly BaseInstruction Or64 = new Or64();
	public static readonly BaseInstruction Xor32 = new Xor32();
	public static readonly BaseInstruction Xor64 = new Xor64();
	public static readonly BaseInstruction MemorySet = new MemorySet();
	public static readonly BaseInstruction MoveCompound = new MoveCompound();
	public static readonly BaseInstruction MoveR4 = new MoveR4();
	public static readonly BaseInstruction MoveR8 = new MoveR8();
	public static readonly BaseInstruction SignExtend8x32 = new SignExtend8x32();
	public static readonly BaseInstruction SignExtend16x32 = new SignExtend16x32();
	public static readonly BaseInstruction SignExtend8x64 = new SignExtend8x64();
	public static readonly BaseInstruction SignExtend16x64 = new SignExtend16x64();
	public static readonly BaseInstruction SignExtend32x64 = new SignExtend32x64();
	public static readonly BaseInstruction ZeroExtend8x32 = new ZeroExtend8x32();
	public static readonly BaseInstruction ZeroExtend16x32 = new ZeroExtend16x32();
	public static readonly BaseInstruction ZeroExtend8x64 = new ZeroExtend8x64();
	public static readonly BaseInstruction ZeroExtend16x64 = new ZeroExtend16x64();
	public static readonly BaseInstruction ZeroExtend32x64 = new ZeroExtend32x64();
	public static readonly BaseInstruction Move32 = new Move32();
	public static readonly BaseInstruction Move64 = new Move64();
	public static readonly BaseInstruction MoveObject = new MoveObject();
	public static readonly BaseInstruction MoveManagedPointer = new MoveManagedPointer();
	public static readonly BaseInstruction MulCarryOut32 = new MulCarryOut32();
	public static readonly BaseInstruction MulCarryOut64 = new MulCarryOut64();
	public static readonly BaseInstruction MulOverflowOut32 = new MulOverflowOut32();
	public static readonly BaseInstruction MulOverflowOut64 = new MulOverflowOut64();
	public static readonly BaseInstruction MulHu32 = new MulHu32();
	public static readonly BaseInstruction MulHu64 = new MulHu64();
	public static readonly BaseInstruction MulHs32 = new MulHs32();
	public static readonly BaseInstruction MulHs64 = new MulHs64();
	public static readonly BaseInstruction MulR4 = new MulR4();
	public static readonly BaseInstruction MulR8 = new MulR8();
	public static readonly BaseInstruction MulSigned32 = new MulSigned32();
	public static readonly BaseInstruction MulSigned64 = new MulSigned64();
	public static readonly BaseInstruction MulUnsigned64 = new MulUnsigned64();
	public static readonly BaseInstruction MulUnsigned32 = new MulUnsigned32();
	public static readonly BaseInstruction Neg32 = new Neg32();
	public static readonly BaseInstruction Neg64 = new Neg64();
	public static readonly BaseInstruction NewArray = new NewArray();
	public static readonly BaseInstruction NewObject = new NewObject();
	public static readonly BaseInstruction NewString = new NewString();
	public static readonly BaseInstruction Nop = new Nop();
	public static readonly BaseInstruction PhiObject = new PhiObject();
	public static readonly BaseInstruction PhiManagedPointer = new PhiManagedPointer();
	public static readonly BaseInstruction Phi32 = new Phi32();
	public static readonly BaseInstruction Phi64 = new Phi64();
	public static readonly BaseInstruction PhiR4 = new PhiR4();
	public static readonly BaseInstruction PhiR8 = new PhiR8();
	public static readonly BaseInstruction Prologue = new Prologue();
	public static readonly BaseInstruction RemR4 = new RemR4();
	public static readonly BaseInstruction RemR8 = new RemR8();
	public static readonly BaseInstruction RemSigned32 = new RemSigned32();
	public static readonly BaseInstruction RemSigned64 = new RemSigned64();
	public static readonly BaseInstruction RemUnsigned32 = new RemUnsigned32();
	public static readonly BaseInstruction RemUnsigned64 = new RemUnsigned64();
	public static readonly BaseInstruction SetReturnR4 = new SetReturnR4();
	public static readonly BaseInstruction SetReturnR8 = new SetReturnR8();
	public static readonly BaseInstruction SetReturn32 = new SetReturn32();
	public static readonly BaseInstruction SetReturn64 = new SetReturn64();
	public static readonly BaseInstruction SetReturnObject = new SetReturnObject();
	public static readonly BaseInstruction SetReturnManagedPointer = new SetReturnManagedPointer();
	public static readonly BaseInstruction SetReturnCompound = new SetReturnCompound();
	public static readonly BaseInstruction ShiftLeft32 = new ShiftLeft32();
	public static readonly BaseInstruction ShiftLeft64 = new ShiftLeft64();
	public static readonly BaseInstruction ShiftRight32 = new ShiftRight32();
	public static readonly BaseInstruction ShiftRight64 = new ShiftRight64();
	public static readonly BaseInstruction StoreCompound = new StoreCompound();
	public static readonly BaseInstruction StoreR4 = new StoreR4();
	public static readonly BaseInstruction StoreR8 = new StoreR8();
	public static readonly BaseInstruction Store8 = new Store8();
	public static readonly BaseInstruction Store16 = new Store16();
	public static readonly BaseInstruction Store32 = new Store32();
	public static readonly BaseInstruction Store64 = new Store64();
	public static readonly BaseInstruction StoreObject = new StoreObject();
	public static readonly BaseInstruction StoreManagedPointer = new StoreManagedPointer();
	public static readonly BaseInstruction StoreParamCompound = new StoreParamCompound();
	public static readonly BaseInstruction StoreParamR4 = new StoreParamR4();
	public static readonly BaseInstruction StoreParamR8 = new StoreParamR8();
	public static readonly BaseInstruction StoreParamObject = new StoreParamObject();
	public static readonly BaseInstruction StoreParamManagedPointer = new StoreParamManagedPointer();
	public static readonly BaseInstruction StoreParam8 = new StoreParam8();
	public static readonly BaseInstruction StoreParam16 = new StoreParam16();
	public static readonly BaseInstruction StoreParam32 = new StoreParam32();
	public static readonly BaseInstruction StoreParam64 = new StoreParam64();
	public static readonly BaseInstruction SubR4 = new SubR4();
	public static readonly BaseInstruction SubR8 = new SubR8();
	public static readonly BaseInstruction Sub32 = new Sub32();
	public static readonly BaseInstruction Sub64 = new Sub64();
	public static readonly BaseInstruction SubManagedPointer = new SubManagedPointer();
	public static readonly BaseInstruction SubCarryOut32 = new SubCarryOut32();
	public static readonly BaseInstruction SubCarryOut64 = new SubCarryOut64();
	public static readonly BaseInstruction SubCarryIn32 = new SubCarryIn32();
	public static readonly BaseInstruction SubCarryIn64 = new SubCarryIn64();
	public static readonly BaseInstruction SubOverflowOut32 = new SubOverflowOut32();
	public static readonly BaseInstruction SubOverflowOut64 = new SubOverflowOut64();
	public static readonly BaseInstruction Switch = new Switch();
	public static readonly BaseInstruction Throw = new Throw();
	public static readonly BaseInstruction Truncate64x32 = new Truncate64x32();
	public static readonly BaseInstruction TryEnd = new TryEnd();
	public static readonly BaseInstruction TryStart = new TryStart();
	public static readonly BaseInstruction SafePoint = new SafePoint();
	public static readonly BaseInstruction UnstableRegionStart = new UnstableRegionStart();
	public static readonly BaseInstruction UnstableRegionEnd = new UnstableRegionEnd();
	public static readonly BaseInstruction Rethrow = new Rethrow();
	public static readonly BaseInstruction GetVirtualFunctionPtr = new GetVirtualFunctionPtr();
	public static readonly BaseInstruction MemoryCopy = new MemoryCopy();
	public static readonly BaseInstruction Box = new Box();
	public static readonly BaseInstruction Box32 = new Box32();
	public static readonly BaseInstruction Box64 = new Box64();
	public static readonly BaseInstruction BoxR4 = new BoxR4();
	public static readonly BaseInstruction BoxR8 = new BoxR8();
	public static readonly BaseInstruction Unbox = new Unbox();
	public static readonly BaseInstruction UnboxAny = new UnboxAny();
	public static readonly BaseInstruction To64 = new To64();
	public static readonly BaseInstruction GetLow32 = new GetLow32();
	public static readonly BaseInstruction GetHigh32 = new GetHigh32();
	public static readonly BaseInstruction IfThenElse32 = new IfThenElse32();
	public static readonly BaseInstruction IfThenElse64 = new IfThenElse64();
	public static readonly BaseInstruction IfThenElseObject = new IfThenElseObject();
	public static readonly BaseInstruction IfThenElseManagedPointer = new IfThenElseManagedPointer();
	public static readonly BaseInstruction BitCopyR4To32 = new BitCopyR4To32();
	public static readonly BaseInstruction BitCopyR8To64 = new BitCopyR8To64();
	public static readonly BaseInstruction BitCopy32ToR4 = new BitCopy32ToR4();
	public static readonly BaseInstruction BitCopy64ToR8 = new BitCopy64ToR8();
	public static readonly BaseInstruction ThrowOverflow = new ThrowOverflow();
	public static readonly BaseInstruction ThrowIndexOutOfRange = new ThrowIndexOutOfRange();
	public static readonly BaseInstruction ThrowDivideByZero = new ThrowDivideByZero();
	public static readonly BaseInstruction CheckArrayBounds = new CheckArrayBounds();
	public static readonly BaseInstruction CheckThrowOverflow = new CheckThrowOverflow();
	public static readonly BaseInstruction CheckThrowIndexOutOfRange = new CheckThrowIndexOutOfRange();
	public static readonly BaseInstruction CheckThrowDivideByZero = new CheckThrowDivideByZero();
	public static readonly BaseInstruction CheckedConversionI32ToU8 = new CheckedConversionI32ToU8();
	public static readonly BaseInstruction CheckedConversionI64ToU8 = new CheckedConversionI64ToU8();
	public static readonly BaseInstruction CheckedConversionR4ToU8 = new CheckedConversionR4ToU8();
	public static readonly BaseInstruction CheckedConversionR8ToU8 = new CheckedConversionR8ToU8();
	public static readonly BaseInstruction CheckedConversionU32ToU8 = new CheckedConversionU32ToU8();
	public static readonly BaseInstruction CheckedConversionU64ToU8 = new CheckedConversionU64ToU8();
	public static readonly BaseInstruction CheckedConversionI64ToI32 = new CheckedConversionI64ToI32();
	public static readonly BaseInstruction CheckedConversionR4ToI32 = new CheckedConversionR4ToI32();
	public static readonly BaseInstruction CheckedConversionR8ToI32 = new CheckedConversionR8ToI32();
	public static readonly BaseInstruction CheckedConversionU32ToI32 = new CheckedConversionU32ToI32();
	public static readonly BaseInstruction CheckedConversionU64ToI32 = new CheckedConversionU64ToI32();
	public static readonly BaseInstruction CheckedConversionR4ToI64 = new CheckedConversionR4ToI64();
	public static readonly BaseInstruction CheckedConversionR8ToI64 = new CheckedConversionR8ToI64();
	public static readonly BaseInstruction CheckedConversionU64ToI64 = new CheckedConversionU64ToI64();
	public static readonly BaseInstruction CheckedConversionI32ToI8 = new CheckedConversionI32ToI8();
	public static readonly BaseInstruction CheckedConversionI64ToI8 = new CheckedConversionI64ToI8();
	public static readonly BaseInstruction CheckedConversionR4ToI8 = new CheckedConversionR4ToI8();
	public static readonly BaseInstruction CheckedConversionR8ToI8 = new CheckedConversionR8ToI8();
	public static readonly BaseInstruction CheckedConversionU32ToI8 = new CheckedConversionU32ToI8();
	public static readonly BaseInstruction CheckedConversionU64ToI8 = new CheckedConversionU64ToI8();
	public static readonly BaseInstruction CheckedConversionI32ToI16 = new CheckedConversionI32ToI16();
	public static readonly BaseInstruction CheckedConversionI64ToI16 = new CheckedConversionI64ToI16();
	public static readonly BaseInstruction CheckedConversionR4ToI16 = new CheckedConversionR4ToI16();
	public static readonly BaseInstruction CheckedConversionR8ToI16 = new CheckedConversionR8ToI16();
	public static readonly BaseInstruction CheckedConversionU32ToI16 = new CheckedConversionU32ToI16();
	public static readonly BaseInstruction CheckedConversionU64ToI16 = new CheckedConversionU64ToI16();
	public static readonly BaseInstruction CheckedConversionI32ToU32 = new CheckedConversionI32ToU32();
	public static readonly BaseInstruction CheckedConversionI64ToU32 = new CheckedConversionI64ToU32();
	public static readonly BaseInstruction CheckedConversionR4ToU32 = new CheckedConversionR4ToU32();
	public static readonly BaseInstruction CheckedConversionR8ToU32 = new CheckedConversionR8ToU32();
	public static readonly BaseInstruction CheckedConversionU64ToU32 = new CheckedConversionU64ToU32();
	public static readonly BaseInstruction CheckedConversionI32ToU64 = new CheckedConversionI32ToU64();
	public static readonly BaseInstruction CheckedConversionI64ToU64 = new CheckedConversionI64ToU64();
	public static readonly BaseInstruction CheckedConversionR4ToU64 = new CheckedConversionR4ToU64();
	public static readonly BaseInstruction CheckedConversionR8ToU64 = new CheckedConversionR8ToU64();
	public static readonly BaseInstruction CheckedConversionI32ToU16 = new CheckedConversionI32ToU16();
	public static readonly BaseInstruction CheckedConversionI64ToU16 = new CheckedConversionI64ToU16();
	public static readonly BaseInstruction CheckedConversionR4ToU16 = new CheckedConversionR4ToU16();
	public static readonly BaseInstruction CheckedConversionR8ToU16 = new CheckedConversionR8ToU16();
	public static readonly BaseInstruction CheckedConversionU32ToU16 = new CheckedConversionU32ToU16();
	public static readonly BaseInstruction CheckedConversionU64ToU16 = new CheckedConversionU64ToU16();
}
