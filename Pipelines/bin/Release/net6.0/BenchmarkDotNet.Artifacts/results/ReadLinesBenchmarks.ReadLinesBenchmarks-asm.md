## .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks.ReadLineUsingStringReaderAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+30],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16, Pipelines]](<ReadLineUsingStringReaderAsync>d__16 ByRef)
       mov       rax,[rsp+38]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 94
```
```assembly
; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].GetAwaiter()
       push      rax
       mov       [rsp],rcx
       mov       rax,[rcx]
       mov       rax,rcx
       add       rsp,8
       ret
; Total bytes of code 16
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter`1[[System.__Canon, System.Private.CoreLib]].GetResult()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L01
M02_L00:
       mov       rax,[rsi]
       mov       rax,[rax+38]
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       jmp       short M02_L00
; Total bytes of code 46
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16, Pipelines]](<ReadLineUsingStringReaderAsync>d__16 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF0BDE4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].InitializeTaskAsPromise()

## .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks.ReadLineUsingPipelineAsync()
       sub       rsp,88
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+80],xmm4
       vmovdqa   xmmword ptr [rsp+rax+90],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0A0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+80],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingPipelineAsync>d__17, Pipelines]](<ReadLineUsingPipelineAsync>d__17 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L02
M00_L01:
       add       rsp,88
       ret
M00_L02:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].InitializeTaskAsPromise()
       jmp       short M00_L01
; Total bytes of code 132
```
```assembly
; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].GetAwaiter()
       push      rax
       mov       [rsp],rcx
       mov       rax,[rcx]
       mov       rax,rcx
       add       rsp,8
       ret
; Total bytes of code 16
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter`1[[System.__Canon, System.Private.CoreLib]].GetResult()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L01
M02_L00:
       mov       rax,[rsi]
       mov       rax,[rax+38]
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       jmp       short M02_L00
; Total bytes of code 46
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingPipelineAsync>d__17, Pipelines]](<ReadLineUsingPipelineAsync>d__17 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF0BDD4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingPipelineAsync>d__17.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].InitializeTaskAsPromise()

## .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks.ReadLineUsingPipelineVer2Async()
       sub       rsp,88
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+80],xmm4
       vmovdqa   xmmword ptr [rsp+rax+90],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0A0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+80],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingPipelineVer2Async>d__19, Pipelines]](<ReadLineUsingPipelineVer2Async>d__19 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L02
M00_L01:
       add       rsp,88
       ret
M00_L02:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].InitializeTaskAsPromise()
       jmp       short M00_L01
; Total bytes of code 132
```
```assembly
; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].GetAwaiter()
       push      rax
       mov       [rsp],rcx
       mov       rax,[rcx]
       mov       rax,rcx
       add       rsp,8
       ret
; Total bytes of code 16
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter`1[[System.__Canon, System.Private.CoreLib]].GetResult()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L01
M02_L00:
       mov       rax,[rsi]
       mov       rax,[rax+38]
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       jmp       short M02_L00
; Total bytes of code 46
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingPipelineVer2Async>d__19, Pipelines]](<ReadLineUsingPipelineVer2Async>d__19 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF0BDA4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingPipelineVer2Async>d__19.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].InitializeTaskAsPromise()

## .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks.ReadLineUsingStringReaderAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+30],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16, Pipelines]](<ReadLineUsingStringReaderAsync>d__16 ByRef)
       mov       rax,[rsp+38]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 94
```
```assembly
; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].GetAwaiter()
       push      rax
       mov       [rsp],rcx
       mov       rax,[rcx]
       mov       rax,rcx
       add       rsp,8
       ret
; Total bytes of code 16
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter`1[[System.__Canon, System.Private.CoreLib]].GetResult()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L01
M02_L00:
       mov       rax,[rsi]
       mov       rax,[rax+38]
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       jmp       short M02_L00
; Total bytes of code 46
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16, Pipelines]](<ReadLineUsingStringReaderAsync>d__16 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF0BDE4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].InitializeTaskAsPromise()

## .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks.ReadLineUsingPipelineAsync()
       sub       rsp,88
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+80],xmm4
       vmovdqa   xmmword ptr [rsp+rax+90],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0A0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+80],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingPipelineAsync>d__17, Pipelines]](<ReadLineUsingPipelineAsync>d__17 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L02
M00_L01:
       add       rsp,88
       ret
M00_L02:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].InitializeTaskAsPromise()
       jmp       short M00_L01
; Total bytes of code 132
```
```assembly
; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].GetAwaiter()
       push      rax
       mov       [rsp],rcx
       mov       rax,[rcx]
       mov       rax,rcx
       add       rsp,8
       ret
; Total bytes of code 16
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter`1[[System.__Canon, System.Private.CoreLib]].GetResult()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L01
M02_L00:
       mov       rax,[rsi]
       mov       rax,[rax+38]
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       jmp       short M02_L00
; Total bytes of code 46
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingPipelineAsync>d__17, Pipelines]](<ReadLineUsingPipelineAsync>d__17 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF0BDD4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingPipelineAsync>d__17.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].InitializeTaskAsPromise()

## .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks.ReadLineUsingPipelineVer2Async()
       sub       rsp,88
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+80],xmm4
       vmovdqa   xmmword ptr [rsp+rax+90],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0A0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+80],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingPipelineVer2Async>d__19, Pipelines]](<ReadLineUsingPipelineVer2Async>d__19 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L02
M00_L01:
       add       rsp,88
       ret
M00_L02:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].InitializeTaskAsPromise()
       jmp       short M00_L01
; Total bytes of code 132
```
```assembly
; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].GetAwaiter()
       push      rax
       mov       [rsp],rcx
       mov       rax,[rcx]
       mov       rax,rcx
       add       rsp,8
       ret
; Total bytes of code 16
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter`1[[System.__Canon, System.Private.CoreLib]].GetResult()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L01
M02_L00:
       mov       rax,[rsi]
       mov       rax,[rax+38]
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       jmp       short M02_L00
; Total bytes of code 46
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingPipelineVer2Async>d__19, Pipelines]](<ReadLineUsingPipelineVer2Async>d__19 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF0BDB4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingPipelineVer2Async>d__19.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].InitializeTaskAsPromise()

## .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks.ReadLineUsingStringReaderAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+30],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16, Pipelines]](<ReadLineUsingStringReaderAsync>d__16 ByRef)
       mov       rax,[rsp+38]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 94
```
```assembly
; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].GetAwaiter()
       push      rax
       mov       [rsp],rcx
       mov       rax,[rcx]
       mov       rax,rcx
       add       rsp,8
       ret
; Total bytes of code 16
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter`1[[System.__Canon, System.Private.CoreLib]].GetResult()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L01
M02_L00:
       mov       rax,[rsi]
       mov       rax,[rax+38]
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       jmp       short M02_L00
; Total bytes of code 46
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16, Pipelines]](<ReadLineUsingStringReaderAsync>d__16 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF0BDD4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].InitializeTaskAsPromise()

## .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks.ReadLineUsingPipelineAsync()
       sub       rsp,88
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+80],xmm4
       vmovdqa   xmmword ptr [rsp+rax+90],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0A0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+80],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingPipelineAsync>d__17, Pipelines]](<ReadLineUsingPipelineAsync>d__17 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L02
M00_L01:
       add       rsp,88
       ret
M00_L02:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].InitializeTaskAsPromise()
       jmp       short M00_L01
; Total bytes of code 132
```
```assembly
; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].GetAwaiter()
       push      rax
       mov       [rsp],rcx
       mov       rax,[rcx]
       mov       rax,rcx
       add       rsp,8
       ret
; Total bytes of code 16
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter`1[[System.__Canon, System.Private.CoreLib]].GetResult()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L01
M02_L00:
       mov       rax,[rsi]
       mov       rax,[rax+38]
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       jmp       short M02_L00
; Total bytes of code 46
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingPipelineAsync>d__17, Pipelines]](<ReadLineUsingPipelineAsync>d__17 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF0BDD4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingPipelineAsync>d__17.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].InitializeTaskAsPromise()

## .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks.ReadLineUsingPipelineVer2Async()
       sub       rsp,88
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+80],xmm4
       vmovdqa   xmmword ptr [rsp+rax+90],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0A0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+80],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingPipelineVer2Async>d__19, Pipelines]](<ReadLineUsingPipelineVer2Async>d__19 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L02
M00_L01:
       add       rsp,88
       ret
M00_L02:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].InitializeTaskAsPromise()
       jmp       short M00_L01
; Total bytes of code 132
```
```assembly
; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].GetAwaiter()
       push      rax
       mov       [rsp],rcx
       mov       rax,[rcx]
       mov       rax,rcx
       add       rsp,8
       ret
; Total bytes of code 16
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter`1[[System.__Canon, System.Private.CoreLib]].GetResult()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L01
M02_L00:
       mov       rax,[rsi]
       mov       rax,[rax+38]
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       jmp       short M02_L00
; Total bytes of code 46
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingPipelineVer2Async>d__19, Pipelines]](<ReadLineUsingPipelineVer2Async>d__19 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF0BDD4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingPipelineVer2Async>d__19.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].InitializeTaskAsPromise()

## .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks.ReadLineUsingStringReaderAsync()
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+30],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16, Pipelines]](<ReadLineUsingStringReaderAsync>d__16 ByRef)
       mov       rax,[rsp+38]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,48
       ret
M00_L01:
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 94
```
```assembly
; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].GetAwaiter()
       push      rax
       mov       [rsp],rcx
       mov       rax,[rcx]
       mov       rax,rcx
       add       rsp,8
       ret
; Total bytes of code 16
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter`1[[System.__Canon, System.Private.CoreLib]].GetResult()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L01
M02_L00:
       mov       rax,[rsi]
       mov       rax,[rax+38]
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       jmp       short M02_L00
; Total bytes of code 46
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16, Pipelines]](<ReadLineUsingStringReaderAsync>d__16 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF0BDA4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].InitializeTaskAsPromise()

## .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks.ReadLineUsingPipelineAsync()
       sub       rsp,88
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+80],xmm4
       vmovdqa   xmmword ptr [rsp+rax+90],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0A0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+80],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingPipelineAsync>d__17, Pipelines]](<ReadLineUsingPipelineAsync>d__17 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L02
M00_L01:
       add       rsp,88
       ret
M00_L02:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].InitializeTaskAsPromise()
       jmp       short M00_L01
; Total bytes of code 132
```
```assembly
; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].GetAwaiter()
       push      rax
       mov       [rsp],rcx
       mov       rax,[rcx]
       mov       rax,rcx
       add       rsp,8
       ret
; Total bytes of code 16
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter`1[[System.__Canon, System.Private.CoreLib]].GetResult()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L01
M02_L00:
       mov       rax,[rsi]
       mov       rax,[rax+38]
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       jmp       short M02_L00
; Total bytes of code 46
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingPipelineAsync>d__17, Pipelines]](<ReadLineUsingPipelineAsync>d__17 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF0BDC4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingPipelineAsync>d__17.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].InitializeTaskAsPromise()

## .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks.ReadLineUsingPipelineVer2Async()
       sub       rsp,88
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+80],xmm4
       vmovdqa   xmmword ptr [rsp+rax+90],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0A0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+80],rax
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingPipelineVer2Async>d__19, Pipelines]](<ReadLineUsingPipelineVer2Async>d__19 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L02
M00_L01:
       add       rsp,88
       ret
M00_L02:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].InitializeTaskAsPromise()
       jmp       short M00_L01
; Total bytes of code 132
```
```assembly
; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].GetAwaiter()
       push      rax
       mov       [rsp],rcx
       mov       rax,[rcx]
       mov       rax,rcx
       add       rsp,8
       ret
; Total bytes of code 16
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter`1[[System.__Canon, System.Private.CoreLib]].GetResult()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L01
M02_L00:
       mov       rax,[rsi]
       mov       rax,[rax+38]
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       jmp       short M02_L00
; Total bytes of code 46
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingPipelineVer2Async>d__19, Pipelines]](<ReadLineUsingPipelineVer2Async>d__19 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF0BDD4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp+0FFE0],rdi
       mov       rdx,[rax+8]
       mov       [rbp+0FFD8],rdx
       mov       rcx,[rax+10]
       mov       [rbp+0FFD0],rcx
       mov       rcx,rsi
       call      ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingPipelineVer2Async>d__19.MoveNext()
       nop
       mov       rcx,[rbp+0FFD0]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp+0FFD0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp+0FFD0]
       mov       rdi,[rbp+0FFE0]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp+0FFD8]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp+0FFD8],0
       je        short M03_L09
       mov       rdx,[rbp+0FFD8]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp+0FFD8]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].InitializeTaskAsPromise()

