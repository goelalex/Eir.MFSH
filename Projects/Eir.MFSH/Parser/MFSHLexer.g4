lexer grammar MFSHLexer;

MFSH: [\n\r \t]* '#' -> pushMode(MFSHMode);
TEXTA: [ \t]* ~[ \t#\n`]+  ~'\n'* '\n';
TEXTB: [ \t]* ~[ \t#\n`]+  ~'\n'* EOF;
TEXTC: [ \t]* '\n';
TEXTD: [ \t]* EOF;
TICKTEXT: [ \t]* '`' ~'\n'* ('\n' | EOF);

CR: '\r' -> skip ;


mode MFSHMode;

APPLY: 'apply';
END: 'end';
IF: 'if' ;
ELSE: 'else' ;
FRAGMENT: 'Fragment' ;
INCOMPATIBLE: 'incompatible';
MACRO: 'macro';
ONCE: 'once';
USE: 'use';

PARENT : 'Parent' ;
TITLE : 'Title' ;
DESCRIPTION : 'Description' ;

STRING: '"' (~('"' | '\\' | '\r' | '\n') | '\\' . )* '"';
MULTILINE_STRING: '"""' .*? '"""' ;

OPAR: '(' ;
COMMA: ',' ;
CPAR: ')' ;
COLON: ':' ;

GT: '>' ;
LT: '<' ;
GE: '>=' ;
LE: '<=' ;
EQ: '==' ;

NAME: [A-Za-z][A-Za-z0-9.]+ | '$' [A-Za-z][A-Za-z0-9.]+ '$' | '%' [A-Za-z][A-Za-z0-9.]+ '%' ;
NUMBER: [0-9.]+;
CMNT: '//' ~('\r' | '\n')*				    -> skip;

MFSHCont: '\n' [ \t]* '#'					-> skip;
MFSHExit: '\n'								-> popMode;

MFSHCR: '\r' -> skip ;
MFSH_SPACE: [ \t]+ -> skip;
