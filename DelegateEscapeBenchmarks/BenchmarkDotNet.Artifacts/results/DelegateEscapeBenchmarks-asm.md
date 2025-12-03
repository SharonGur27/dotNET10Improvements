## .NET 10.0.0 (10.0.25.52411), X64 RyuJIT AVX2
```assembly
; DelegateEscapeBenchmarks.NonEscapingNonClosure()
       push      rbx
       sub       rsp,20
       mov       rcx,1DA7A401490
       mov       rax,[rcx]
       test      rax,rax
       je        short M00_L01
M00_L00:
       mov       rdx,offset DelegateEscapeBenchmarks+<>c.<NonEscapingNonClosure>b__4_0(Int32)
       cmp       [rax+18],rdx
       jne       short M00_L02
       mov       eax,1A
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1DA7A401488
       mov       rdx,[rdx]
       mov       rcx,rbx
       mov       r8,offset DelegateEscapeBenchmarks+<>c.<NonEscapingNonClosure>b__4_0(Int32)
       call      qword ptr [7FF9EB016BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1DA7A401490
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       short M00_L00
M00_L02:
       mov       edx,0D
       mov       rcx,[rax+8]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax+18]
; Total bytes of code 141
```
```assembly
; DelegateEscapeBenchmarks+<>c.<NonEscapingNonClosure>b__4_0(Int32)
       lea       eax,[rdx+rdx]
       ret
; Total bytes of code 4
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FF9EB4CEAD8]
       int       3
; Total bytes of code 44
```

## .NET 9.0.11 (9.0.1125.51716), X64 RyuJIT AVX2
```assembly
; DelegateEscapeBenchmarks.NonEscapingNonClosure()
       push      rbx
       sub       rsp,20
       mov       rax,2697FC014A0
       mov       r8,[rax]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rax,offset DelegateEscapeBenchmarks+<>c.<NonEscapingNonClosure>b__4_0(Int32)
       cmp       [r8+18],rax
       jne       short M00_L02
       mov       eax,1A
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2697FC01498
       mov       rdx,[rdx]
       mov       rcx,rbx
       mov       r8,offset DelegateEscapeBenchmarks+<>c.<NonEscapingNonClosure>b__4_0(Int32)
       call      qword ptr [7FFA0AA569D0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2697FC014A0
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
       jmp       short M00_L00
M00_L02:
       mov       edx,0D
       mov       rcx,[r8+8]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [r8+18]
; Total bytes of code 141
```
```assembly
; DelegateEscapeBenchmarks+<>c.<NonEscapingNonClosure>b__4_0(Int32)
       lea       eax,[rdx+rdx]
       ret
; Total bytes of code 4
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFA0AEEDB18]
       int       3
; Total bytes of code 44
```

## .NET 10.0.0 (10.0.25.52411), X64 RyuJIT AVX2
```assembly
; DelegateEscapeBenchmarks.EscapingStoredFunc(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,offset MT_DelegateEscapeBenchmarks+<>c__DisplayClass1_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DelegateEscapeBenchmarks+<>c__DisplayClass1_0.<EscapingStoredFunc>b__0(Int32)
       mov       [rsi+18],rcx
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,offset DelegateEscapeBenchmarks+<>c__DisplayClass1_0.<EscapingStoredFunc>b__0(Int32)
       cmp       [rsi+18],rax
       jne       short M00_L00
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       add       eax,0D
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       edx,0D
       mov       rcx,[rsi+8]
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+18]
; Total bytes of code 146
```
```assembly
; DelegateEscapeBenchmarks+<>c__DisplayClass1_0.<EscapingStoredFunc>b__0(Int32)
       mov       eax,edx
       add       eax,[rcx+8]
       ret
; Total bytes of code 6
```

## .NET 9.0.11 (9.0.1125.51716), X64 RyuJIT AVX2
```assembly
; DelegateEscapeBenchmarks.EscapingStoredFunc(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,offset MT_DelegateEscapeBenchmarks+<>c__DisplayClass1_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DelegateEscapeBenchmarks+<>c__DisplayClass1_0.<EscapingStoredFunc>b__0(Int32)
       mov       [rsi+18],rcx
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,offset DelegateEscapeBenchmarks+<>c__DisplayClass1_0.<EscapingStoredFunc>b__0(Int32)
       cmp       [rsi+18],rax
       jne       short M00_L00
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       add       eax,0D
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       edx,0D
       mov       rcx,[rsi+8]
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+18]
; Total bytes of code 146
```
```assembly
; DelegateEscapeBenchmarks+<>c__DisplayClass1_0.<EscapingStoredFunc>b__0(Int32)
       mov       eax,edx
       add       eax,[rcx+8]
       ret
; Total bytes of code 6
```

## .NET 10.0.0 (10.0.25.52411), X64 RyuJIT AVX2
```assembly
; DelegateEscapeBenchmarks.NonEscaping(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,edx
       mov       rcx,offset MT_DelegateEscapeBenchmarks+<>c__DisplayClass2_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],ebx
       mov       eax,[rax+8]
       add       eax,0D
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 37
```

## .NET 9.0.11 (9.0.1125.51716), X64 RyuJIT AVX2
```assembly
; DelegateEscapeBenchmarks.NonEscaping(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,edx
       mov       rcx,offset MT_DelegateEscapeBenchmarks+<>c__DisplayClass2_0
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsi+8],ebx
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,offset DelegateEscapeBenchmarks+<>c__DisplayClass2_0.<NonEscaping>b__0(Int32)
       mov       [rbx+18],rax
       cmp       [rbx+18],rax
       jne       short M00_L00
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       add       eax,0D
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L00:
       mov       edx,0D
       mov       rcx,[rbx+8]
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+18]
; Total bytes of code 118
```
```assembly
; DelegateEscapeBenchmarks+<>c__DisplayClass2_0.<NonEscaping>b__0(Int32)
       mov       eax,edx
       add       eax,[rcx+8]
       ret
; Total bytes of code 6
```

