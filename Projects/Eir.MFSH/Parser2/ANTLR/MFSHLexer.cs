//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from MFSHLexer.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace MFSH.Parser2 {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class MFSHLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		APPLY=1, END=2, FSHLINE=3, INCLUDE=4, INCOMPATIBLE=5, MACRO=6, ONCE=7, 
		PROFILE=8, USE=9, STRING=10, MULTILINE_STRING=11, OPAR=12, COMMA=13, CPAR=14, 
		GT=15, NAME=16, WS=17;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"APPLY", "END", "FSHLINE", "INCLUDE", "INCOMPATIBLE", "MACRO", "ONCE", 
		"PROFILE", "USE", "STRING", "MULTILINE_STRING", "OPAR", "COMMA", "CPAR", 
		"GT", "NAME", "WS"
	};


	public MFSHLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public MFSHLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'apply'", "'end'", "'FshLine'", "'include'", "'incompatible'", 
		"'macro'", "'once'", "'profile'", "'use'", null, null, "'('", "','", "')'", 
		"'>'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "APPLY", "END", "FSHLINE", "INCLUDE", "INCOMPATIBLE", "MACRO", "ONCE", 
		"PROFILE", "USE", "STRING", "MULTILINE_STRING", "OPAR", "COMMA", "CPAR", 
		"GT", "NAME", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "MFSHLexer.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static MFSHLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x13', '\xA3', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\t', 
		'\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', 
		'\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', 
		'\x3', '\v', '\x3', '\v', '\a', '\v', 'h', '\n', '\v', '\f', '\v', '\xE', 
		'\v', 'k', '\v', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', 
		'\x3', '\f', '\x3', '\f', '\x3', '\f', '\a', '\f', 't', '\n', '\f', '\f', 
		'\f', '\xE', '\f', 'w', '\v', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', 
		'\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x11', '\x3', 
		'\x11', '\x6', '\x11', '\x87', '\n', '\x11', '\r', '\x11', '\xE', '\x11', 
		'\x88', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x6', '\x11', '\x8E', 
		'\n', '\x11', '\r', '\x11', '\xE', '\x11', '\x8F', '\x3', '\x11', '\x3', 
		'\x11', '\x3', '\x11', '\x3', '\x11', '\x6', '\x11', '\x96', '\n', '\x11', 
		'\r', '\x11', '\xE', '\x11', '\x97', '\x3', '\x11', '\x5', '\x11', '\x9B', 
		'\n', '\x11', '\x3', '\x12', '\x6', '\x12', '\x9E', '\n', '\x12', '\r', 
		'\x12', '\xE', '\x12', '\x9F', '\x3', '\x12', '\x3', '\x12', '\x3', 'u', 
		'\x2', '\x13', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', 
		'\a', '\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', 
		'\x17', '\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', 
		'!', '\x12', '#', '\x13', '\x3', '\x2', '\x6', '\x6', '\x2', '\f', '\f', 
		'\xF', '\xF', '$', '$', '^', '^', '\x4', '\x2', '\x43', '\\', '\x63', 
		'|', '\x5', '\x2', '\x32', ';', '\x43', '\\', '\x63', '|', '\x5', '\x2', 
		'\v', '\f', '\xF', '\xF', '\"', '\"', '\x2', '\xAB', '\x2', '\x3', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', '\x2', '\x11', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x3', '%', '\x3', '\x2', '\x2', 
		'\x2', '\x5', '+', '\x3', '\x2', '\x2', '\x2', '\a', '/', '\x3', '\x2', 
		'\x2', '\x2', '\t', '\x37', '\x3', '\x2', '\x2', '\x2', '\v', '?', '\x3', 
		'\x2', '\x2', '\x2', '\r', 'L', '\x3', '\x2', '\x2', '\x2', '\xF', 'R', 
		'\x3', '\x2', '\x2', '\x2', '\x11', 'W', '\x3', '\x2', '\x2', '\x2', '\x13', 
		'_', '\x3', '\x2', '\x2', '\x2', '\x15', '\x63', '\x3', '\x2', '\x2', 
		'\x2', '\x17', 'n', '\x3', '\x2', '\x2', '\x2', '\x19', '|', '\x3', '\x2', 
		'\x2', '\x2', '\x1B', '~', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x80', 
		'\x3', '\x2', '\x2', '\x2', '\x1F', '\x82', '\x3', '\x2', '\x2', '\x2', 
		'!', '\x9A', '\x3', '\x2', '\x2', '\x2', '#', '\x9D', '\x3', '\x2', '\x2', 
		'\x2', '%', '&', '\a', '\x63', '\x2', '\x2', '&', '\'', '\a', 'r', '\x2', 
		'\x2', '\'', '(', '\a', 'r', '\x2', '\x2', '(', ')', '\a', 'n', '\x2', 
		'\x2', ')', '*', '\a', '{', '\x2', '\x2', '*', '\x4', '\x3', '\x2', '\x2', 
		'\x2', '+', ',', '\a', 'g', '\x2', '\x2', ',', '-', '\a', 'p', '\x2', 
		'\x2', '-', '.', '\a', '\x66', '\x2', '\x2', '.', '\x6', '\x3', '\x2', 
		'\x2', '\x2', '/', '\x30', '\a', 'H', '\x2', '\x2', '\x30', '\x31', '\a', 
		'u', '\x2', '\x2', '\x31', '\x32', '\a', 'j', '\x2', '\x2', '\x32', '\x33', 
		'\a', 'N', '\x2', '\x2', '\x33', '\x34', '\a', 'k', '\x2', '\x2', '\x34', 
		'\x35', '\a', 'p', '\x2', '\x2', '\x35', '\x36', '\a', 'g', '\x2', '\x2', 
		'\x36', '\b', '\x3', '\x2', '\x2', '\x2', '\x37', '\x38', '\a', 'k', '\x2', 
		'\x2', '\x38', '\x39', '\a', 'p', '\x2', '\x2', '\x39', ':', '\a', '\x65', 
		'\x2', '\x2', ':', ';', '\a', 'n', '\x2', '\x2', ';', '<', '\a', 'w', 
		'\x2', '\x2', '<', '=', '\a', '\x66', '\x2', '\x2', '=', '>', '\a', 'g', 
		'\x2', '\x2', '>', '\n', '\x3', '\x2', '\x2', '\x2', '?', '@', '\a', 'k', 
		'\x2', '\x2', '@', '\x41', '\a', 'p', '\x2', '\x2', '\x41', '\x42', '\a', 
		'\x65', '\x2', '\x2', '\x42', '\x43', '\a', 'q', '\x2', '\x2', '\x43', 
		'\x44', '\a', 'o', '\x2', '\x2', '\x44', '\x45', '\a', 'r', '\x2', '\x2', 
		'\x45', '\x46', '\a', '\x63', '\x2', '\x2', '\x46', 'G', '\a', 'v', '\x2', 
		'\x2', 'G', 'H', '\a', 'k', '\x2', '\x2', 'H', 'I', '\a', '\x64', '\x2', 
		'\x2', 'I', 'J', '\a', 'n', '\x2', '\x2', 'J', 'K', '\a', 'g', '\x2', 
		'\x2', 'K', '\f', '\x3', '\x2', '\x2', '\x2', 'L', 'M', '\a', 'o', '\x2', 
		'\x2', 'M', 'N', '\a', '\x63', '\x2', '\x2', 'N', 'O', '\a', '\x65', '\x2', 
		'\x2', 'O', 'P', '\a', 't', '\x2', '\x2', 'P', 'Q', '\a', 'q', '\x2', 
		'\x2', 'Q', '\xE', '\x3', '\x2', '\x2', '\x2', 'R', 'S', '\a', 'q', '\x2', 
		'\x2', 'S', 'T', '\a', 'p', '\x2', '\x2', 'T', 'U', '\a', '\x65', '\x2', 
		'\x2', 'U', 'V', '\a', 'g', '\x2', '\x2', 'V', '\x10', '\x3', '\x2', '\x2', 
		'\x2', 'W', 'X', '\a', 'r', '\x2', '\x2', 'X', 'Y', '\a', 't', '\x2', 
		'\x2', 'Y', 'Z', '\a', 'q', '\x2', '\x2', 'Z', '[', '\a', 'h', '\x2', 
		'\x2', '[', '\\', '\a', 'k', '\x2', '\x2', '\\', ']', '\a', 'n', '\x2', 
		'\x2', ']', '^', '\a', 'g', '\x2', '\x2', '^', '\x12', '\x3', '\x2', '\x2', 
		'\x2', '_', '`', '\a', 'w', '\x2', '\x2', '`', '\x61', '\a', 'u', '\x2', 
		'\x2', '\x61', '\x62', '\a', 'g', '\x2', '\x2', '\x62', '\x14', '\x3', 
		'\x2', '\x2', '\x2', '\x63', 'i', '\a', '$', '\x2', '\x2', '\x64', 'h', 
		'\n', '\x2', '\x2', '\x2', '\x65', '\x66', '\a', '^', '\x2', '\x2', '\x66', 
		'h', '\v', '\x2', '\x2', '\x2', 'g', '\x64', '\x3', '\x2', '\x2', '\x2', 
		'g', '\x65', '\x3', '\x2', '\x2', '\x2', 'h', 'k', '\x3', '\x2', '\x2', 
		'\x2', 'i', 'g', '\x3', '\x2', '\x2', '\x2', 'i', 'j', '\x3', '\x2', '\x2', 
		'\x2', 'j', 'l', '\x3', '\x2', '\x2', '\x2', 'k', 'i', '\x3', '\x2', '\x2', 
		'\x2', 'l', 'm', '\a', '$', '\x2', '\x2', 'm', '\x16', '\x3', '\x2', '\x2', 
		'\x2', 'n', 'o', '\a', '$', '\x2', '\x2', 'o', 'p', '\a', '$', '\x2', 
		'\x2', 'p', 'q', '\a', '$', '\x2', '\x2', 'q', 'u', '\x3', '\x2', '\x2', 
		'\x2', 'r', 't', '\v', '\x2', '\x2', '\x2', 's', 'r', '\x3', '\x2', '\x2', 
		'\x2', 't', 'w', '\x3', '\x2', '\x2', '\x2', 'u', 'v', '\x3', '\x2', '\x2', 
		'\x2', 'u', 's', '\x3', '\x2', '\x2', '\x2', 'v', 'x', '\x3', '\x2', '\x2', 
		'\x2', 'w', 'u', '\x3', '\x2', '\x2', '\x2', 'x', 'y', '\a', '$', '\x2', 
		'\x2', 'y', 'z', '\a', '$', '\x2', '\x2', 'z', '{', '\a', '$', '\x2', 
		'\x2', '{', '\x18', '\x3', '\x2', '\x2', '\x2', '|', '}', '\a', '*', '\x2', 
		'\x2', '}', '\x1A', '\x3', '\x2', '\x2', '\x2', '~', '\x7F', '\a', '.', 
		'\x2', '\x2', '\x7F', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x80', '\x81', 
		'\a', '+', '\x2', '\x2', '\x81', '\x1E', '\x3', '\x2', '\x2', '\x2', '\x82', 
		'\x83', '\a', '@', '\x2', '\x2', '\x83', ' ', '\x3', '\x2', '\x2', '\x2', 
		'\x84', '\x86', '\t', '\x3', '\x2', '\x2', '\x85', '\x87', '\t', '\x4', 
		'\x2', '\x2', '\x86', '\x85', '\x3', '\x2', '\x2', '\x2', '\x87', '\x88', 
		'\x3', '\x2', '\x2', '\x2', '\x88', '\x86', '\x3', '\x2', '\x2', '\x2', 
		'\x88', '\x89', '\x3', '\x2', '\x2', '\x2', '\x89', '\x9B', '\x3', '\x2', 
		'\x2', '\x2', '\x8A', '\x8B', '\a', '&', '\x2', '\x2', '\x8B', '\x8D', 
		'\t', '\x3', '\x2', '\x2', '\x8C', '\x8E', '\t', '\x4', '\x2', '\x2', 
		'\x8D', '\x8C', '\x3', '\x2', '\x2', '\x2', '\x8E', '\x8F', '\x3', '\x2', 
		'\x2', '\x2', '\x8F', '\x8D', '\x3', '\x2', '\x2', '\x2', '\x8F', '\x90', 
		'\x3', '\x2', '\x2', '\x2', '\x90', '\x91', '\x3', '\x2', '\x2', '\x2', 
		'\x91', '\x9B', '\a', '&', '\x2', '\x2', '\x92', '\x93', '\a', '\'', '\x2', 
		'\x2', '\x93', '\x95', '\t', '\x3', '\x2', '\x2', '\x94', '\x96', '\t', 
		'\x4', '\x2', '\x2', '\x95', '\x94', '\x3', '\x2', '\x2', '\x2', '\x96', 
		'\x97', '\x3', '\x2', '\x2', '\x2', '\x97', '\x95', '\x3', '\x2', '\x2', 
		'\x2', '\x97', '\x98', '\x3', '\x2', '\x2', '\x2', '\x98', '\x99', '\x3', 
		'\x2', '\x2', '\x2', '\x99', '\x9B', '\a', '\'', '\x2', '\x2', '\x9A', 
		'\x84', '\x3', '\x2', '\x2', '\x2', '\x9A', '\x8A', '\x3', '\x2', '\x2', 
		'\x2', '\x9A', '\x92', '\x3', '\x2', '\x2', '\x2', '\x9B', '\"', '\x3', 
		'\x2', '\x2', '\x2', '\x9C', '\x9E', '\t', '\x5', '\x2', '\x2', '\x9D', 
		'\x9C', '\x3', '\x2', '\x2', '\x2', '\x9E', '\x9F', '\x3', '\x2', '\x2', 
		'\x2', '\x9F', '\x9D', '\x3', '\x2', '\x2', '\x2', '\x9F', '\xA0', '\x3', 
		'\x2', '\x2', '\x2', '\xA0', '\xA1', '\x3', '\x2', '\x2', '\x2', '\xA1', 
		'\xA2', '\b', '\x12', '\x2', '\x2', '\xA2', '$', '\x3', '\x2', '\x2', 
		'\x2', '\v', '\x2', 'g', 'i', 'u', '\x88', '\x8F', '\x97', '\x9A', '\x9F', 
		'\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace MFSH.Parser2
