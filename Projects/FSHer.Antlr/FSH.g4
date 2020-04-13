grammar FSH;

doc:                entity* EOF;
entity:             alias | profile | extension | invariant | instance | valueSet | codeSystem | ruleSet | mapping | macroDef;

alias:              KW_ALIAS sequence EQUAL sequence;

profile:            KW_PROFILE sequence sdMetadata+ sdRule*;
extension:          KW_EXTENSION sequence sdMetadata* sdRule*;
sdMetadata:         parent | id | title | description | mixins;
sdRule:             cardRule | flagRule | valueSetRule | fixedValueRule | containsRule | onlyRule | obeysRule | caretValueRule | macroRule;

instance:           KW_INSTANCE sequence instanceMetadata* fixedValueRule*;
instanceMetadata:   instanceOf | title | description | usage | mixins;

invariant:          KW_INVARIANT sequence invariantMetadata+;
invariantMetadata:  description | expression | xpath | severity;

valueSet:           KW_VALUESET sequence vsMetadata* (caretValueRule | vsComponent)*;
vsMetadata:         id | title | description;
codeSystem:         KW_CODESYSTEM sequence csMetadata* (caretValueRule | concept)*;
csMetadata:         id | title | description;

ruleSet:            KW_RULESET sequence sdRule+;
macroDef:           KW_MACRODEF sequence sdRule+;

mapping:            KW_MAPPING sequence mappingMetadata* mappingRule*;
mappingMetadata:    id | source | target | description | title;

// METADATA FIELDS
parent:             KW_PARENT sequence;
id:                 KW_ID sequence;
title:              KW_TITLE STRING;
description:        KW_DESCRIPTION (STRING | MULTILINE_STRING);
expression:         KW_EXPRESSION STRING;
xpath:              KW_XPATH STRING;
severity:           KW_SEVERITY code;
instanceOf:         KW_INSTANCEOF sequence;
usage:              KW_USAGE code;
mixins:             KW_MIXINS sequence (COMMA sequence)*;
source:             KW_SOURCE sequence;
target:             KW_TARGET STRING;


// RULES
cardRule:           STAR path CARD flag*;
flagRule:           STAR (path | paths) flag+;
valueSetRule:       STAR path KW_UNITS? KW_FROM sequence strength?;
fixedValueRule:     STAR path KW_UNITS? EQUAL value KW_EXACTLY?;
containsRule:       STAR path KW_CONTAINS item (KW_AND item)*;
onlyRule:           STAR path KW_ONLY targetType (KW_OR targetType)*;
obeysRule:          STAR path? KW_OBEYS sequence (KW_AND sequence)*;
caretValueRule:     STAR path? caretPath EQUAL value;
mappingRule:        STAR path? ARROW STRING STRING? code?;
macroRule:          KW_MACRO sequence ( '(' sequence (COMMA sequence)* ')' )?;

// VALUESET COMPONENTS
vsComponent:        STAR KW_EXCLUDE? ( vsConceptComponent | vsFilterComponent );
vsConceptComponent: code vsComponentFrom?
                    | code (COMMA code)+ vsComponentFrom;
vsFilterComponent:  KW_CODES vsComponentFrom (KW_WHERE vsFilterList)?;
vsComponentFrom:    KW_FROM (vsFromSystem (KW_AND vsFromValueset)? | vsFromValueset (KW_AND vsFromSystem)?);
vsFromSystem:       KW_SYSTEM sequence;
vsFromValueset:     KW_VSREFERENCE sequence (COMMA sequence)*;
vsFilterList:       (vsFilterDefinition KW_AND)* vsFilterDefinition;
vsFilterDefinition: sequence vsFilterOperator vsFilterValue?;
vsFilterOperator:   EQUAL | sequence;
vsFilterValue:      code | KW_TRUE | KW_FALSE | REGEX | STRING;

// MISC
path:               sequence | KW_SYSTEM;
paths:              sequence (COMMA sequence)*;
caretPath:          CARET_SEQUENCE;
flag:               KW_MOD | KW_MS | KW_SU | KW_TU | KW_NORMATIVE | KW_DRAFT;
strength:           KW_EXAMPLE | KW_PREFERRED | KW_EXTENSIBLE | KW_REQUIRED;
value:              sequence | STRING | MULTILINE_STRING | NUMBER | DATETIME | TIME | reference | code | quantity | ratio | bool ;
item:               sequence (KW_NAMED sequence)? CARD flag*;
code:               sequence? '#' (sequence | CONCEPT_STRING) STRING?;
concept:            STAR code;
quantity:           NUMBER UNIT;
ratio:              ratioPart COLON ratioPart;
reference:          REFERENCE STRING?;
ratioPart:          NUMBER | quantity;
bool:               KW_TRUE | KW_FALSE;
targetType:         sequence | reference;

sequence:           SEQUENCE ;
// KEYWORDS
KW_ALIAS:           'Alias' WS* ':';
KW_PROFILE:         'Profile' WS* ':';
KW_EXTENSION:       'Extension' WS* ':';
KW_INSTANCE:        'Instance' WS* ':';
KW_INSTANCEOF:      'InstanceOf' WS* ':';
KW_INVARIANT:       'Invariant' WS* ':';
KW_VALUESET:        'ValueSet' WS* ':';
KW_CODESYSTEM:      'CodeSystem' WS* ':';
KW_RULESET:         'RuleSet' WS* ':';
KW_MAPPING:         'Mapping' WS* ':';
KW_MIXINS:          'Mixins' WS* ':';
KW_PARENT:          'Parent' WS* ':';
KW_ID:              'Id' WS* ':';
KW_TITLE:           'Title' WS* ':';
KW_DESCRIPTION:     'Description' WS* ':';
KW_EXPRESSION:      'Expression' WS* ':';
KW_XPATH:           'XPath' WS* ':';
KW_SEVERITY:        'Severity' WS* ':';
KW_USAGE:           'Usage' WS* ':';
KW_SOURCE:          'Source' WS* ':';
KW_TARGET:          'Target' WS* ':';
KW_MOD:             '?!';
KW_MS:              'MS';
KW_SU:              'SU';
KW_TU:              'TU';
KW_NORMATIVE:       'N';
KW_DRAFT:           'D';
KW_FROM:            'from';
KW_EXAMPLE:         '(' WS* 'example' WS* ')';
KW_PREFERRED:       '(' WS* 'preferred' WS* ')';
KW_EXTENSIBLE:      '(' WS* 'extensible' WS* ')';
KW_REQUIRED:        '(' WS* 'required' WS* ')';
KW_CONTAINS:        'contains';
KW_NAMED:           'named';
KW_AND:             'and';
KW_ONLY:            'only';
KW_OR:              'or';
KW_OBEYS:           'obeys';
KW_TRUE:            'true';
KW_FALSE:           'false';
KW_EXCLUDE:         'exclude';
KW_CODES:           'codes';
KW_WHERE:           'where';
KW_VSREFERENCE:     'valueset';
KW_SYSTEM:          'system';
KW_UNITS:           'units';
KW_EXACTLY:         '(' WS* 'exactly' WS* ')';
KW_MACRO:           'Macro' ;
KW_MACRODEF:        'MacroDef' WS* ':';

// SYMBOLS
EQUAL:              '=';
STAR:               '*'  [0-9]*;
COLON:              ':';
COMMA:              ',';
ARROW:              '->';

// PATTERNS

                 //  "    CHARS    "
STRING:             '"' (~[\\"] | '\\"' | '\\\\')* '"';

                 //  """ CHARS """
MULTILINE_STRING:   '"""' .*? '"""';

                 //  +/- ? DIGITS( .  DIGITS)?
NUMBER:             [+\-]? [0-9]+('.' [0-9]+)?;

                 //   '  UCUM UNIT   '
UNIT:               '\'' (~[\\'])* '\'';

CONCEPT_STRING:      '"' (~[ \t\r\n\f\\"] | '\\"' | '\\\\')+ (WS (~[ \t\r\n\f\\"] | '\\"' | '\\\\')+)* '"';

                 //        YEAR         ( -   MONTH   ( -    DAY    ( T TIME )?)?)?
DATETIME:           [0-9][0-9][0-9][0-9]('-'[0-9][0-9]('-'[0-9][0-9]('T' TIME)?)?)?;

                 //    HOUR   ( :   MINUTE  ( :   SECOND  ( . MILLI )?)?)?( Z  |     +/-        HOUR   :  MINUTE   )?
TIME:               [0-9][0-9](':'[0-9][0-9](':'[0-9][0-9]('.'[0-9]+)?)?)?('Z' | ('+' | '-')[0-9][0-9]':'[0-9][0-9])?;

                 // DIGITS  ..  (DIGITS |  * )
CARD:               ([0-9]+)? '..' ([0-9]+ | '*')?;

                 //  Reference       (        ITEM         |         ITEM         )
REFERENCE:          'Reference' WS* '(' WS* SEQUENCE WS* ('|' WS* SEQUENCE WS*)* ')';

                 //  ^  NON-WHITESPACE
CARET_SEQUENCE:     '^' ~[ \t\r\n\f]+;

                 // '/' EXPRESSION '/'
REGEX:              '/' ('\\/' | ~[*/\r\n])('\\/' | ~[/\r\n])* '/';
SEQUENCE:           [A-Za-z_][A-Za-z0-9_]*;

// FRAGMENTS
fragment WS: [ \t\r\n\f];

// IGNORED TOKENS
WHITESPACE:         WS -> channel(HIDDEN);
BLOCK_COMMENT:      '/*' .*? '*/' -> skip;
LINE_COMMENT:       '//' .*? [\r\n] -> skip;