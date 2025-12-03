## .NET 10.0.0 (10.0.25.52411), X64 RyuJIT AVX2
```assembly
; ObjectStackAllocationDelegates.Sum(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,edx
       mov       rcx,offset MT_ObjectStackAllocationDelegates+<>c__DisplayClass0_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],ebx
       mov       eax,[rax+8]
       mov       ecx,eax
       add       eax,ecx
       add       eax,eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 40
```

## .NET 9.0.11 (9.0.1125.51716), X64 RyuJIT AVX2
```assembly
; ObjectStackAllocationDelegates.Sum(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,edx
       mov       rcx,offset MT_ObjectStackAllocationDelegates+<>c__DisplayClass0_0
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsi+8],ebx
       mov       rcx,offset MT_System.Func<System.Int32, System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,offset ObjectStackAllocationDelegates+<>c__DisplayClass0_0.<Sum>b__0(Int32)
       mov       [rbx+18],rax
       mov       edx,[rsi+8]
       cmp       [rbx+18],rax
       jne       short M00_L01
       mov       rax,[rbx+8]
       add       edx,[rax+8]
       mov       eax,edx
M00_L00:
       add       eax,eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       jmp       short M00_L00
; Total bytes of code 109
```
```assembly
; ObjectStackAllocationDelegates+<>c__DisplayClass0_0.<Sum>b__0(Int32)
       mov       eax,edx
       add       eax,[rcx+8]
       ret
; Total bytes of code 6
```

