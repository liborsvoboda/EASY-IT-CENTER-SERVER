"use strict";(self.webpackChunkdocs=self.webpackChunkdocs||[]).push([[5e3],{3905:(e,t,n)=>{n.d(t,{Zo:()=>d,kt:()=>m});var r=n(7294);function i(e,t,n){return t in e?Object.defineProperty(e,t,{value:n,enumerable:!0,configurable:!0,writable:!0}):e[t]=n,e}function l(e,t){var n=Object.keys(e);if(Object.getOwnPropertySymbols){var r=Object.getOwnPropertySymbols(e);t&&(r=r.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),n.push.apply(n,r)}return n}function a(e){for(var t=1;t<arguments.length;t++){var n=null!=arguments[t]?arguments[t]:{};t%2?l(Object(n),!0).forEach((function(t){i(e,t,n[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(n)):l(Object(n)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(n,t))}))}return e}function s(e,t){if(null==e)return{};var n,r,i=function(e,t){if(null==e)return{};var n,r,i={},l=Object.keys(e);for(r=0;r<l.length;r++)n=l[r],t.indexOf(n)>=0||(i[n]=e[n]);return i}(e,t);if(Object.getOwnPropertySymbols){var l=Object.getOwnPropertySymbols(e);for(r=0;r<l.length;r++)n=l[r],t.indexOf(n)>=0||Object.prototype.propertyIsEnumerable.call(e,n)&&(i[n]=e[n])}return i}var o=r.createContext({}),p=function(e){var t=r.useContext(o),n=t;return e&&(n="function"==typeof e?e(t):a(a({},t),e)),n},d=function(e){var t=p(e.components);return r.createElement(o.Provider,{value:t},e.children)},u="mdxType",c={inlineCode:"code",wrapper:function(e){var t=e.children;return r.createElement(r.Fragment,{},t)}},f=r.forwardRef((function(e,t){var n=e.components,i=e.mdxType,l=e.originalType,o=e.parentName,d=s(e,["components","mdxType","originalType","parentName"]),u=p(n),f=i,m=u["".concat(o,".").concat(f)]||u[f]||c[f]||l;return n?r.createElement(m,a(a({ref:t},d),{},{components:n})):r.createElement(m,a({ref:t},d))}));function m(e,t){var n=arguments,i=t&&t.mdxType;if("string"==typeof e||i){var l=n.length,a=new Array(l);a[0]=f;var s={};for(var o in t)hasOwnProperty.call(t,o)&&(s[o]=t[o]);s.originalType=e,s[u]="string"==typeof e?e:i,a[1]=s;for(var p=2;p<l;p++)a[p]=n[p];return r.createElement.apply(null,a)}return r.createElement.apply(null,n)}f.displayName="MDXCreateElement"},4731:(e,t,n)=>{n.r(t),n.d(t,{assets:()=>o,contentTitle:()=>a,default:()=>u,frontMatter:()=>l,metadata:()=>s,toc:()=>p});var r=n(7462),i=(n(7294),n(3905));const l={id:"internal.TestResult",title:"Interface: TestResult",sidebar_label:"TestResult",custom_edit_url:null},a=void 0,s={unversionedId:"api/interfaces/internal.TestResult",id:"api/interfaces/internal.TestResult",title:"Interface: TestResult",description:"_internal.TestResult",source:"@site/docs/api/interfaces/internal.TestResult.md",sourceDirName:"api/interfaces",slug:"/api/interfaces/internal.TestResult",permalink:"/docs/api/interfaces/internal.TestResult",draft:!1,editUrl:null,tags:[],version:"current",frontMatter:{id:"internal.TestResult",title:"Interface: TestResult",sidebar_label:"TestResult",custom_edit_url:null}},o={},p=[{value:"Properties",id:"properties",level:2},{value:"duration",id:"duration",level:3},{value:"Defined in",id:"defined-in",level:4},{value:"errors",id:"errors",level:3},{value:"Defined in",id:"defined-in-1",level:4},{value:"status",id:"status",level:3},{value:"Defined in",id:"defined-in-2",level:4},{value:"testPath",id:"testpath",level:3},{value:"Defined in",id:"defined-in-3",level:4}],d={toc:p};function u(e){let{components:t,...n}=e;return(0,i.kt)("wrapper",(0,r.Z)({},d,n,{components:t,mdxType:"MDXLayout"}),(0,i.kt)("p",null,(0,i.kt)("a",{parentName:"p",href:"/docs/api/modules/internal"},"_internal"),".TestResult"),(0,i.kt)("h2",{id:"properties"},"Properties"),(0,i.kt)("h3",{id:"duration"},"duration"),(0,i.kt)("p",null,"\u2022 ",(0,i.kt)("strong",{parentName:"p"},"duration"),": ",(0,i.kt)("inlineCode",{parentName:"p"},"number")),(0,i.kt)("h4",{id:"defined-in"},"Defined in"),(0,i.kt)("p",null,(0,i.kt)("a",{parentName:"p",href:"https://github.com/live-codes/livecodes/blob/18c61b4/src/sdk/models.ts#L1092"},"models.ts:1092")),(0,i.kt)("hr",null),(0,i.kt)("h3",{id:"errors"},"errors"),(0,i.kt)("p",null,"\u2022 ",(0,i.kt)("strong",{parentName:"p"},"errors"),": ",(0,i.kt)("inlineCode",{parentName:"p"},"string"),"[]"),(0,i.kt)("h4",{id:"defined-in-1"},"Defined in"),(0,i.kt)("p",null,(0,i.kt)("a",{parentName:"p",href:"https://github.com/live-codes/livecodes/blob/18c61b4/src/sdk/models.ts#L1093"},"models.ts:1093")),(0,i.kt)("hr",null),(0,i.kt)("h3",{id:"status"},"status"),(0,i.kt)("p",null,"\u2022 ",(0,i.kt)("strong",{parentName:"p"},"status"),": ",(0,i.kt)("inlineCode",{parentName:"p"},'"fail"')," ","|"," ",(0,i.kt)("inlineCode",{parentName:"p"},'"pass"')," ","|"," ",(0,i.kt)("inlineCode",{parentName:"p"},'"skip"')),(0,i.kt)("h4",{id:"defined-in-2"},"Defined in"),(0,i.kt)("p",null,(0,i.kt)("a",{parentName:"p",href:"https://github.com/live-codes/livecodes/blob/18c61b4/src/sdk/models.ts#L1094"},"models.ts:1094")),(0,i.kt)("hr",null),(0,i.kt)("h3",{id:"testpath"},"testPath"),(0,i.kt)("p",null,"\u2022 ",(0,i.kt)("strong",{parentName:"p"},"testPath"),": ",(0,i.kt)("inlineCode",{parentName:"p"},"string"),"[]"),(0,i.kt)("h4",{id:"defined-in-3"},"Defined in"),(0,i.kt)("p",null,(0,i.kt)("a",{parentName:"p",href:"https://github.com/live-codes/livecodes/blob/18c61b4/src/sdk/models.ts#L1095"},"models.ts:1095")))}u.isMDXComponent=!0}}]);