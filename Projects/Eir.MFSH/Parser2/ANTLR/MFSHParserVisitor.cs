//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from MFSHParser.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace MFSH.Parser2 {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="MFSHParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public interface IMFSHParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="MFSHParser.document"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDocument([NotNull] MFSHParser.DocumentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MFSHParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCommand([NotNull] MFSHParser.CommandContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MFSHParser.fshLine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFshLine([NotNull] MFSHParser.FshLineContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MFSHParser.apply"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitApply([NotNull] MFSHParser.ApplyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MFSHParser.end"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnd([NotNull] MFSHParser.EndContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MFSHParser.include"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInclude([NotNull] MFSHParser.IncludeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MFSHParser.incompatible"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIncompatible([NotNull] MFSHParser.IncompatibleContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MFSHParser.macro"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMacro([NotNull] MFSHParser.MacroContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MFSHParser.profile"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProfile([NotNull] MFSHParser.ProfileContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MFSHParser.redirect"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRedirect([NotNull] MFSHParser.RedirectContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MFSHParser.use"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUse([NotNull] MFSHParser.UseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MFSHParser.anyString"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAnyString([NotNull] MFSHParser.AnyStringContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MFSHParser.multiLineString"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiLineString([NotNull] MFSHParser.MultiLineStringContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MFSHParser.singleString"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSingleString([NotNull] MFSHParser.SingleStringContext context);
}
} // namespace MFSH.Parser2
