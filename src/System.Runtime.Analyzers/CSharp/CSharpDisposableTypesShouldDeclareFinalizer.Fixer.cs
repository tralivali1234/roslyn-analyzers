// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Composition;
using System.Runtime.Analyzers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;

namespace System.Runtime.CSharp.Analyzers
{
    /// <summary>
    /// CA2216: Disposable types should declare finalizer
    /// </summary>
    [ExportCodeFixProvider(LanguageNames.CSharp), Shared]
    public class CSharpDisposableTypesShouldDeclareFinalizerFixer : DisposableTypesShouldDeclareFinalizerFixer
    {
    }
}