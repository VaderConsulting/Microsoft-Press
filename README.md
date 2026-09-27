# Microsoft Press

Microsoft Press Workflow Step by Step Chapter 1 working copy: a VS 2012 C# console host (.NET 3.0) that CreateWorkflow-starts SequentialWorkflowActivity Workflow1 with PostalCode from args[0] (or empty). EvaluatePostalCode regex-matches a US ZIP (five digits or ZIP+4) or a Canadian postcode and IfElseActivity EvalPostalCode runs PostalCodeValid; PostalCodeInvalid is wired on the false branch but a comment records it is never run because both branches share that condition. Open `Workflow Step by Step/Chapter 1/PCodeFlow/PCodeFlow.sln`. This tree is a working copy of third-party Microsoft Press sample source kept in Dave Robinson's Historical Dev archive; authorship stays with the original authors.

Working copy from my Historical Dev folder.

**Source last updated:** 2013-04-21  
**Language:** C#  
**Target:** v3.0  
**Output:** Exe

## What it is

Microsoft Press Workflow Step by Step Chapter 1 working copy: a VS 2012 C# console host (.NET 3.0) that CreateWorkflow-starts SequentialWorkflowActivity Workflow1 with PostalCode from args[0] (or empty). EvaluatePostalCode regex-matches a US ZIP (five digits or ZIP+4) or a Canadian postcode and IfElseActivity EvalPostalCode runs PostalCodeValid; PostalCodeInvalid is wired on the false branch but a comment records it is never run because both branches share that condition. Open `Workflow Step by Step/Chapter 1/PCodeFlow/PCodeFlow.sln`. This tree is a working copy of third-party Microsoft Press sample source kept in Dave Robinson's Historical Dev archive; authorship stays with the original authors.

## Solution structure

| Project | Language | Path |
|---------|----------|------|
| `PCodeFlow` | C# | `Workflow Step by Step/Chapter 1/PCodeFlow/PCodeFlow/PCodeFlow.csproj` |

## How to open

Open `Workflow Step by Step/Chapter 1/PCodeFlow/PCodeFlow.sln` in Visual Studio.

## Requirements

- Visual Studio 2012, .NET Framework 3.0

## Attribution and provenance

- **Assembly copyright:** Copyright ©  2013

## License

Original license terms apply where recorded in the tree or package metadata. This repository does not claim authorship. See `THIRD_PARTY_NOTICES.md`.
