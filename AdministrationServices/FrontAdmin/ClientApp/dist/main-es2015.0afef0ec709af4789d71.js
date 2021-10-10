(window.webpackJsonp=window.webpackJsonp||[]).push([[1],{0:function(e,t,n){e.exports=n("zUnb")},zUnb:function(e,t,n){"use strict";function r(e){return"function"==typeof e}n.r(t);let s=!1;const o={Promise:void 0,set useDeprecatedSynchronousErrorHandling(e){if(e){const e=new Error;console.warn("DEPRECATED! RxJS was set to use deprecated synchronous error handling behavior by code at: \n"+e.stack)}else s&&console.log("RxJS: Back to a better error behavior. Thank you. <3");s=e},get useDeprecatedSynchronousErrorHandling(){return s}};function i(e){setTimeout(()=>{throw e},0)}const l={closed:!0,next(e){},error(e){if(o.useDeprecatedSynchronousErrorHandling)throw e;i(e)},complete(){}},u=(()=>Array.isArray||(e=>e&&"number"==typeof e.length))();function c(e){return null!==e&&"object"==typeof e}const a=(()=>{function e(e){return Error.call(this),this.message=e?`${e.length} errors occurred during unsubscription:\n${e.map((e,t)=>`${t+1}) ${e.toString()}`).join("\n  ")}`:"",this.name="UnsubscriptionError",this.errors=e,this}return e.prototype=Object.create(Error.prototype),e})();let h=(()=>{class e{constructor(e){this.closed=!1,this._parentOrParents=null,this._subscriptions=null,e&&(this._ctorUnsubscribe=!0,this._unsubscribe=e)}unsubscribe(){let t;if(this.closed)return;let{_parentOrParents:n,_ctorUnsubscribe:s,_unsubscribe:o,_subscriptions:i}=this;if(this.closed=!0,this._parentOrParents=null,this._subscriptions=null,n instanceof e)n.remove(this);else if(null!==n)for(let e=0;e<n.length;++e)n[e].remove(this);if(r(o)){s&&(this._unsubscribe=void 0);try{o.call(this)}catch(l){t=l instanceof a?d(l.errors):[l]}}if(u(i)){let e=-1,n=i.length;for(;++e<n;){const n=i[e];if(c(n))try{n.unsubscribe()}catch(l){t=t||[],l instanceof a?t=t.concat(d(l.errors)):t.push(l)}}}if(t)throw new a(t)}add(t){let n=t;if(!t)return e.EMPTY;switch(typeof t){case"function":n=new e(t);case"object":if(n===this||n.closed||"function"!=typeof n.unsubscribe)return n;if(this.closed)return n.unsubscribe(),n;if(!(n instanceof e)){const t=n;n=new e,n._subscriptions=[t]}break;default:throw new Error("unrecognized teardown "+t+" added to Subscription.")}let{_parentOrParents:r}=n;if(null===r)n._parentOrParents=this;else if(r instanceof e){if(r===this)return n;n._parentOrParents=[r,this]}else{if(-1!==r.indexOf(this))return n;r.push(this)}const s=this._subscriptions;return null===s?this._subscriptions=[n]:s.push(n),n}remove(e){const t=this._subscriptions;if(t){const n=t.indexOf(e);-1!==n&&t.splice(n,1)}}}return e.EMPTY=function(e){return e.closed=!0,e}(new e),e})();function d(e){return e.reduce((e,t)=>e.concat(t instanceof a?t.errors:t),[])}const f=(()=>"function"==typeof Symbol?Symbol("rxSubscriber"):"@@rxSubscriber_"+Math.random())();class p extends h{constructor(e,t,n){switch(super(),this.syncErrorValue=null,this.syncErrorThrown=!1,this.syncErrorThrowable=!1,this.isStopped=!1,arguments.length){case 0:this.destination=l;break;case 1:if(!e){this.destination=l;break}if("object"==typeof e){e instanceof p?(this.syncErrorThrowable=e.syncErrorThrowable,this.destination=e,e.add(this)):(this.syncErrorThrowable=!0,this.destination=new _(this,e));break}default:this.syncErrorThrowable=!0,this.destination=new _(this,e,t,n)}}[f](){return this}static create(e,t,n){const r=new p(e,t,n);return r.syncErrorThrowable=!1,r}next(e){this.isStopped||this._next(e)}error(e){this.isStopped||(this.isStopped=!0,this._error(e))}complete(){this.isStopped||(this.isStopped=!0,this._complete())}unsubscribe(){this.closed||(this.isStopped=!0,super.unsubscribe())}_next(e){this.destination.next(e)}_error(e){this.destination.error(e),this.unsubscribe()}_complete(){this.destination.complete(),this.unsubscribe()}_unsubscribeAndRecycle(){const{_parentOrParents:e}=this;return this._parentOrParents=null,this.unsubscribe(),this.closed=!1,this.isStopped=!1,this._parentOrParents=e,this}}class _ extends p{constructor(e,t,n,s){let o;super(),this._parentSubscriber=e;let i=this;r(t)?o=t:t&&(o=t.next,n=t.error,s=t.complete,t!==l&&(i=Object.create(t),r(i.unsubscribe)&&this.add(i.unsubscribe.bind(i)),i.unsubscribe=this.unsubscribe.bind(this))),this._context=i,this._next=o,this._error=n,this._complete=s}next(e){if(!this.isStopped&&this._next){const{_parentSubscriber:t}=this;o.useDeprecatedSynchronousErrorHandling&&t.syncErrorThrowable?this.__tryOrSetError(t,this._next,e)&&this.unsubscribe():this.__tryOrUnsub(this._next,e)}}error(e){if(!this.isStopped){const{_parentSubscriber:t}=this,{useDeprecatedSynchronousErrorHandling:n}=o;if(this._error)n&&t.syncErrorThrowable?(this.__tryOrSetError(t,this._error,e),this.unsubscribe()):(this.__tryOrUnsub(this._error,e),this.unsubscribe());else if(t.syncErrorThrowable)n?(t.syncErrorValue=e,t.syncErrorThrown=!0):i(e),this.unsubscribe();else{if(this.unsubscribe(),n)throw e;i(e)}}}complete(){if(!this.isStopped){const{_parentSubscriber:e}=this;if(this._complete){const t=()=>this._complete.call(this._context);o.useDeprecatedSynchronousErrorHandling&&e.syncErrorThrowable?(this.__tryOrSetError(e,t),this.unsubscribe()):(this.__tryOrUnsub(t),this.unsubscribe())}else this.unsubscribe()}}__tryOrUnsub(e,t){try{e.call(this._context,t)}catch(n){if(this.unsubscribe(),o.useDeprecatedSynchronousErrorHandling)throw n;i(n)}}__tryOrSetError(e,t,n){if(!o.useDeprecatedSynchronousErrorHandling)throw new Error("bad call");try{t.call(this._context,n)}catch(r){return o.useDeprecatedSynchronousErrorHandling?(e.syncErrorValue=r,e.syncErrorThrown=!0,!0):(i(r),!0)}return!1}_unsubscribe(){const{_parentSubscriber:e}=this;this._context=null,this._parentSubscriber=null,e.unsubscribe()}}const y=(()=>"function"==typeof Symbol&&Symbol.observable||"@@observable")();function m(e){return e}let g=(()=>{class e{constructor(e){this._isScalar=!1,e&&(this._subscribe=e)}lift(t){const n=new e;return n.source=this,n.operator=t,n}subscribe(e,t,n){const{operator:r}=this,s=function(e,t,n){if(e){if(e instanceof p)return e;if(e[f])return e[f]()}return e||t||n?new p(e,t,n):new p(l)}(e,t,n);if(s.add(r?r.call(s,this.source):this.source||o.useDeprecatedSynchronousErrorHandling&&!s.syncErrorThrowable?this._subscribe(s):this._trySubscribe(s)),o.useDeprecatedSynchronousErrorHandling&&s.syncErrorThrowable&&(s.syncErrorThrowable=!1,s.syncErrorThrown))throw s.syncErrorValue;return s}_trySubscribe(e){try{return this._subscribe(e)}catch(t){o.useDeprecatedSynchronousErrorHandling&&(e.syncErrorThrown=!0,e.syncErrorValue=t),function(e){for(;e;){const{closed:t,destination:n,isStopped:r}=e;if(t||r)return!1;e=n&&n instanceof p?n:null}return!0}(e)?e.error(t):console.warn(t)}}forEach(e,t){return new(t=v(t))((t,n)=>{let r;r=this.subscribe(t=>{try{e(t)}catch(s){n(s),r&&r.unsubscribe()}},n,t)})}_subscribe(e){const{source:t}=this;return t&&t.subscribe(e)}[y](){return this}pipe(...e){return 0===e.length?this:(0===(t=e).length?m:1===t.length?t[0]:function(e){return t.reduce((e,t)=>t(e),e)})(this);var t}toPromise(e){return new(e=v(e))((e,t)=>{let n;this.subscribe(e=>n=e,e=>t(e),()=>e(n))})}}return e.create=t=>new e(t),e})();function v(e){if(e||(e=o.Promise||Promise),!e)throw new Error("no Promise impl found");return e}const b=(()=>{function e(){return Error.call(this),this.message="object unsubscribed",this.name="ObjectUnsubscribedError",this}return e.prototype=Object.create(Error.prototype),e})();class w extends h{constructor(e,t){super(),this.subject=e,this.subscriber=t,this.closed=!1}unsubscribe(){if(this.closed)return;this.closed=!0;const e=this.subject,t=e.observers;if(this.subject=null,!t||0===t.length||e.isStopped||e.closed)return;const n=t.indexOf(this.subscriber);-1!==n&&t.splice(n,1)}}class C extends p{constructor(e){super(e),this.destination=e}}let E=(()=>{class e extends g{constructor(){super(),this.observers=[],this.closed=!1,this.isStopped=!1,this.hasError=!1,this.thrownError=null}[f](){return new C(this)}lift(e){const t=new x(this,this);return t.operator=e,t}next(e){if(this.closed)throw new b;if(!this.isStopped){const{observers:t}=this,n=t.length,r=t.slice();for(let s=0;s<n;s++)r[s].next(e)}}error(e){if(this.closed)throw new b;this.hasError=!0,this.thrownError=e,this.isStopped=!0;const{observers:t}=this,n=t.length,r=t.slice();for(let s=0;s<n;s++)r[s].error(e);this.observers.length=0}complete(){if(this.closed)throw new b;this.isStopped=!0;const{observers:e}=this,t=e.length,n=e.slice();for(let r=0;r<t;r++)n[r].complete();this.observers.length=0}unsubscribe(){this.isStopped=!0,this.closed=!0,this.observers=null}_trySubscribe(e){if(this.closed)throw new b;return super._trySubscribe(e)}_subscribe(e){if(this.closed)throw new b;return this.hasError?(e.error(this.thrownError),h.EMPTY):this.isStopped?(e.complete(),h.EMPTY):(this.observers.push(e),new w(this,e))}asObservable(){const e=new g;return e.source=this,e}}return e.create=(e,t)=>new x(e,t),e})();class x extends E{constructor(e,t){super(),this.destination=e,this.source=t}next(e){const{destination:t}=this;t&&t.next&&t.next(e)}error(e){const{destination:t}=this;t&&t.error&&this.destination.error(e)}complete(){const{destination:e}=this;e&&e.complete&&this.destination.complete()}_subscribe(e){const{source:t}=this;return t?this.source.subscribe(e):h.EMPTY}}class k{constructor(e,t){this.project=e,this.thisArg=t}call(e,t){return t.subscribe(new T(e,this.project,this.thisArg))}}class T extends p{constructor(e,t,n){super(e),this.project=t,this.count=0,this.thisArg=n||this}_next(e){let t;try{t=this.project.call(this.thisArg,e,this.count++)}catch(n){return void this.destination.error(n)}this.destination.next(t)}}const S=e=>t=>{for(let n=0,r=e.length;n<r&&!t.closed;n++)t.next(e[n]);t.complete()};function I(){return"function"==typeof Symbol&&Symbol.iterator?Symbol.iterator:"@@iterator"}const A=I(),D=e=>e&&"number"==typeof e.length&&"function"!=typeof e;function O(e){return!!e&&"function"!=typeof e.subscribe&&"function"==typeof e.then}const j=e=>{if(e&&"function"==typeof e[y])return r=e,e=>{const t=r[y]();if("function"!=typeof t.subscribe)throw new TypeError("Provided object does not correctly implement Symbol.observable");return t.subscribe(e)};if(D(e))return S(e);if(O(e))return n=e,e=>(n.then(t=>{e.closed||(e.next(t),e.complete())},t=>e.error(t)).then(null,i),e);if(e&&"function"==typeof e[A])return t=e,e=>{const n=t[A]();for(;;){let t;try{t=n.next()}catch(r){return e.error(r),e}if(t.done){e.complete();break}if(e.next(t.value),e.closed)break}return"function"==typeof n.return&&e.add(()=>{n.return&&n.return()}),e};{const t=c(e)?"an invalid object":`'${e}'`;throw new TypeError(`You provided ${t} where a stream was expected. You can provide an Observable, Promise, Array, or Iterable.`)}var t,n,r};function H(e,t){return new g(n=>{const r=new h;let s=0;return r.add(t.schedule(function(){s!==e.length?(n.next(e[s++]),n.closed||r.add(this.schedule())):n.complete()})),r})}class P extends p{constructor(e){super(),this.parent=e}_next(e){this.parent.notifyNext(e)}_error(e){this.parent.notifyError(e),this.unsubscribe()}_complete(){this.parent.notifyComplete(),this.unsubscribe()}}class R extends p{notifyNext(e){this.destination.next(e)}notifyError(e){this.destination.error(e)}notifyComplete(){this.destination.complete()}}function N(e,t,n=Number.POSITIVE_INFINITY){return"function"==typeof t?r=>r.pipe(N((n,r)=>{return(s=e(n,r),o?function(e,t){if(null!=e){if(function(e){return e&&"function"==typeof e[y]}(e))return function(e,t){return new g(n=>{const r=new h;return r.add(t.schedule(()=>{const s=e[y]();r.add(s.subscribe({next(e){r.add(t.schedule(()=>n.next(e)))},error(e){r.add(t.schedule(()=>n.error(e)))},complete(){r.add(t.schedule(()=>n.complete()))}}))})),r})}(e,t);if(O(e))return function(e,t){return new g(n=>{const r=new h;return r.add(t.schedule(()=>e.then(e=>{r.add(t.schedule(()=>{n.next(e),r.add(t.schedule(()=>n.complete()))}))},e=>{r.add(t.schedule(()=>n.error(e)))}))),r})}(e,t);if(D(e))return H(e,t);if(function(e){return e&&"function"==typeof e[A]}(e)||"string"==typeof e)return function(e,t){if(!e)throw new Error("Iterable cannot be null");return new g(n=>{const r=new h;let s;return r.add(()=>{s&&"function"==typeof s.return&&s.return()}),r.add(t.schedule(()=>{s=e[A](),r.add(t.schedule(function(){if(n.closed)return;let e,t;try{const n=s.next();e=n.value,t=n.done}catch(r){return void n.error(r)}t?n.complete():(n.next(e),this.schedule())}))})),r})}(e,t)}throw new TypeError((null!==e&&typeof e||e)+" is not observable")}(s,o):s instanceof g?s:new g(j(s))).pipe(function(e,t){return function(t){return t.lift(new k(e,undefined))}}((e,s)=>t(n,e,r,s)));var s,o},n)):("number"==typeof t&&(n=t),t=>t.lift(new M(e,n)))}class M{constructor(e,t=Number.POSITIVE_INFINITY){this.project=e,this.concurrent=t}call(e,t){return t.subscribe(new F(e,this.project,this.concurrent))}}class F extends R{constructor(e,t,n=Number.POSITIVE_INFINITY){super(e),this.project=t,this.concurrent=n,this.hasCompleted=!1,this.buffer=[],this.active=0,this.index=0}_next(e){this.active<this.concurrent?this._tryNext(e):this.buffer.push(e)}_tryNext(e){let t;const n=this.index++;try{t=this.project(e,n)}catch(r){return void this.destination.error(r)}this.active++,this._innerSub(t)}_innerSub(e){const t=new P(this),n=this.destination;n.add(t);const r=function(e,t){if(t.closed)return;if(e instanceof g)return e.subscribe(t);let n;try{n=j(e)(t)}catch(r){t.error(r)}return n}(e,t);r!==t&&n.add(r)}_complete(){this.hasCompleted=!0,0===this.active&&0===this.buffer.length&&this.destination.complete(),this.unsubscribe()}notifyNext(e){this.destination.next(e)}notifyComplete(){const e=this.buffer;this.active--,e.length>0?this._next(e.shift()):0===this.active&&this.hasCompleted&&this.destination.complete()}}function V(){return function(e){return e.lift(new L(e))}}class L{constructor(e){this.connectable=e}call(e,t){const{connectable:n}=this;n._refCount++;const r=new Z(e,n),s=t.subscribe(r);return r.closed||(r.connection=n.connect()),s}}class Z extends p{constructor(e,t){super(e),this.connectable=t}_unsubscribe(){const{connectable:e}=this;if(!e)return void(this.connection=null);this.connectable=null;const t=e._refCount;if(t<=0)return void(this.connection=null);if(e._refCount=t-1,t>1)return void(this.connection=null);const{connection:n}=this,r=e._connection;this.connection=null,!r||n&&r!==n||r.unsubscribe()}}class B extends g{constructor(e,t){super(),this.source=e,this.subjectFactory=t,this._refCount=0,this._isComplete=!1}_subscribe(e){return this.getSubject().subscribe(e)}getSubject(){const e=this._subject;return e&&!e.isStopped||(this._subject=this.subjectFactory()),this._subject}connect(){let e=this._connection;return e||(this._isComplete=!1,e=this._connection=new h,e.add(this.source.subscribe(new z(this.getSubject(),this))),e.closed&&(this._connection=null,e=h.EMPTY)),e}refCount(){return V()(this)}}const $=(()=>{const e=B.prototype;return{operator:{value:null},_refCount:{value:0,writable:!0},_subject:{value:null,writable:!0},_connection:{value:null,writable:!0},_subscribe:{value:e._subscribe},_isComplete:{value:e._isComplete,writable:!0},getSubject:{value:e.getSubject},connect:{value:e.connect},refCount:{value:e.refCount}}})();class z extends C{constructor(e,t){super(e),this.connectable=t}_error(e){this._unsubscribe(),super._error(e)}_complete(){this.connectable._isComplete=!0,this._unsubscribe(),super._complete()}_unsubscribe(){const e=this.connectable;if(e){this.connectable=null;const t=e._connection;e._refCount=0,e._subject=null,e._connection=null,t&&t.unsubscribe()}}}function U(){return new E}
/**
 * @license Angular v11.2.14
 * (c) 2010-2021 Google LLC. https://angular.io/
 * License: MIT
 */
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */function W(e){for(let t in e)if(e[t]===W)return t;throw Error("Could not find renamed property on target object.")}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */function G(e){if("string"==typeof e)return e;if(Array.isArray(e))return"["+e.map(G).join(", ")+"]";if(null==e)return""+e;if(e.overriddenName)return`${e.overriddenName}`;if(e.name)return`${e.name}`;const t=e.toString();if(null==t)return""+t;const n=t.indexOf("\n");return-1===n?t:t.substring(0,n)}function q(e,t){return null==e||""===e?null===t?"":t:null==t||""===t?e:e+" "+t}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */const Q=W({__forward_ref__:W});function J(e){return e.__forward_ref__=J,e.toString=function(){return G(this())},e}function K(e){return"function"==typeof(t=e)&&t.hasOwnProperty(Q)&&t.__forward_ref__===J?e():e;var t;
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */}class Y extends Error{constructor(e,t){super(function(e,t){return`${e?`NG0${e}: `:""}${t}`
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */}(e,t)),this.code=e}}function X(e){return"function"==typeof e?e.name||e.toString():"object"==typeof e&&null!=e&&"function"==typeof e.type?e.type.name||e.type.toString():function(e){return"string"==typeof e?e:null==e?"":String(e)}(e)}function ee(e,t){const n=t?` in ${t}`:"";throw new Y("201",`No provider for ${X(e)} found${n}`)}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */function te(e){return{token:e.token,providedIn:e.providedIn||null,factory:e.factory,value:void 0}}function ne(e){return{providers:e.providers||[],imports:e.imports||[]}}function re(e){return se(e,ie)||se(e,ue)}function se(e,t){return e.hasOwnProperty(t)?e[t]:null}function oe(e){return e&&(e.hasOwnProperty(le)||e.hasOwnProperty(ce))?e[le]:null}const ie=W({"\u0275prov":W}),le=W({"\u0275inj":W}),ue=W({ngInjectableDef:W}),ce=W({ngInjectorDef:W});
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */var ae=function(e){return e[e.Default=0]="Default",e[e.Host=1]="Host",e[e.Self=2]="Self",e[e.SkipSelf=4]="SkipSelf",e[e.Optional=8]="Optional",e}({});
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */let he;function de(e){const t=he;return he=e,t}function fe(e,t,n){const r=re(e);return r&&"root"==r.providedIn?void 0===r.value?r.value=r.factory():r.value:n&ae.Optional?null:void 0!==t?t:void ee(G(e),"Injector")}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */function pe(e){return{toString:e}.toString()}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */var _e=function(e){return e[e.OnPush=0]="OnPush",e[e.Default=1]="Default",e}({}),ye=function(e){return e[e.Emulated=0]="Emulated",e[e.None=2]="None",e[e.ShadowDom=3]="ShadowDom",e}({});
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */const me="undefined"!=typeof globalThis&&globalThis,ge="undefined"!=typeof window&&window,ve="undefined"!=typeof self&&"undefined"!=typeof WorkerGlobalScope&&self instanceof WorkerGlobalScope&&self,be="undefined"!=typeof global&&global,we=me||be||ge||ve,Ce={},Ee=[],xe=W({"\u0275cmp":W}),ke=W({"\u0275dir":W}),Te=W({"\u0275pipe":W}),Se=W({"\u0275mod":W}),Ie=W({"\u0275loc":W}),Ae=W({"\u0275fac":W}),De=W({__NG_ELEMENT_ID__:W});
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */let Oe=0;function je(e){return Me(e)||function(e){return e[ke]||null}(e)}function He(e){return function(e){return e[Te]||null}(e)}const Pe={};function Re(e){const t={type:e.type,bootstrap:e.bootstrap||Ee,declarations:e.declarations||Ee,imports:e.imports||Ee,exports:e.exports||Ee,transitiveCompileScopes:null,schemas:e.schemas||null,id:e.id||null};return null!=e.id&&pe(()=>{Pe[e.id]=e.type}),t}function Ne(e,t){if(null==e)return Ce;const n={};for(const r in e)if(e.hasOwnProperty(r)){let s=e[r],o=s;Array.isArray(s)&&(o=s[1],s=s[0]),n[s]=r,t&&(t[s]=o)}return n}function Me(e){return e[xe]||null}function Fe(e,t){const n=e[Se]||null;if(!n&&!0===t)throw new Error(`Type ${G(e)} does not have '\u0275mod' property.`);return n}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */function Ve(e){return Array.isArray(e)&&"object"==typeof e[1]}function Le(e){return Array.isArray(e)&&!0===e[1]}function Ze(e){return 0!=(8&e.flags)}function Be(e){return null!==e.template}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */function $e(e,t){return e.hasOwnProperty(Ae)?e[Ae]:null}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */class ze{constructor(e,t,n){this.previousValue=e,this.currentValue=t,this.firstChange=n}isFirstChange(){return this.firstChange}}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */function Ue(){const e=Ge(this),t=null==e?void 0:e.current;if(t){const n=e.previous;if(n===Ce)e.previous=t;else for(let e in t)n[e]=t[e];e.current=null,this.ngOnChanges(t)}}function We(e,t,n,r){const s=Ge(e)||function(e,t){return e.__ngSimpleChanges__=t}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */(e,{previous:Ce,current:null}),o=s.current||(s.current={}),i=s.previous,l=this.declaredInputs[n],u=i[l];o[l]=new ze(u&&u.currentValue,t,i===Ce),e[r]=t}function Ge(e){return e.__ngSimpleChanges__||null}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */let qe;function Qe(e){return!!e.listen}const Je={createRenderer:(e,t)=>void 0!==qe?qe:"undefined"!=typeof document?document:void 0};
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */function Ke(e){for(;Array.isArray(e);)e=e[0];return e}function Ye(e,t){return Ke(t[e.index])}function Xe(e,t){const n=t[e];return Ve(n)?n:n[0]}function et(e){const t=function(e){return e.__ngContext__||null}(e);return t?Array.isArray(t)?t:t.lView:null}function tt(e){return 128==(128&e[2])}function nt(e,t){return null==t?null:e[t]}function rt(e){e[18]=0}function st(e,t){e[5]+=t;let n=e,r=e[3];for(;null!==r&&(1===t&&1===n[5]||-1===t&&0===n[5]);)r[5]+=t,n=r,r=r[3]}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */const ot={lFrame:Ct(null),bindingsEnabled:!0,isInCheckNoChangesMode:!1};function it(){return ot.bindingsEnabled}function lt(){return ot.lFrame.lView}function ut(){return ot.lFrame.tView}function ct(){let e=at();for(;null!==e&&64===e.type;)e=e.parent;return e}function at(){return ot.lFrame.currentTNode}function ht(e,t){const n=ot.lFrame;n.currentTNode=e,n.isParent=t}function dt(){return ot.lFrame.isParent}function ft(){return ot.isInCheckNoChangesMode}function pt(e){ot.isInCheckNoChangesMode=e}function _t(e,t){const n=ot.lFrame;n.bindingIndex=n.bindingRootIndex=e,yt(t)}function yt(e){ot.lFrame.currentDirectiveIndex=e}function mt(e){ot.lFrame.currentQueryIndex=e}function gt(e){const t=e[1];return 2===t.type?t.declTNode:1===t.type?e[6]:null}function vt(e,t,n){if(n&ae.SkipSelf){let r=t,s=e;for(;r=r.parent,!(null!==r||n&ae.Host||(r=gt(s),null===r)||(s=s[15],10&r.type)););if(null===r)return!1;t=r,e=s}const r=ot.lFrame=wt();return r.currentTNode=t,r.lView=e,!0}function bt(e){const t=wt(),n=e[1];ot.lFrame=t,t.currentTNode=n.firstChild,t.lView=e,t.tView=n,t.contextLView=e,t.bindingIndex=n.bindingStartIndex,t.inI18n=!1}function wt(){const e=ot.lFrame,t=null===e?null:e.child;return null===t?Ct(e):t}function Ct(e){const t={currentTNode:null,isParent:!0,lView:null,tView:null,selectedIndex:-1,contextLView:null,elementDepthCount:0,currentNamespace:null,currentDirectiveIndex:-1,bindingRootIndex:-1,bindingIndex:-1,currentQueryIndex:0,parent:e,child:null,inI18n:!1};return null!==e&&(e.child=t),t}function Et(){const e=ot.lFrame;return ot.lFrame=e.parent,e.currentTNode=null,e.lView=null,e}const xt=Et;function kt(){const e=Et();e.isParent=!0,e.tView=null,e.selectedIndex=-1,e.contextLView=null,e.elementDepthCount=0,e.currentDirectiveIndex=-1,e.currentNamespace=null,e.bindingRootIndex=-1,e.bindingIndex=-1,e.currentQueryIndex=0}function Tt(e){ot.lFrame.selectedIndex=e}function St(e,t){for(let n=t.directiveStart,r=t.directiveEnd;n<r;n++){const t=e.data[n].type.prototype,{ngAfterContentInit:r,ngAfterContentChecked:s,ngAfterViewInit:o,ngAfterViewChecked:i,ngOnDestroy:l}=t;r&&(e.contentHooks||(e.contentHooks=[])).push(-n,r),s&&((e.contentHooks||(e.contentHooks=[])).push(n,s),(e.contentCheckHooks||(e.contentCheckHooks=[])).push(n,s)),o&&(e.viewHooks||(e.viewHooks=[])).push(-n,o),i&&((e.viewHooks||(e.viewHooks=[])).push(n,i),(e.viewCheckHooks||(e.viewCheckHooks=[])).push(n,i)),null!=l&&(e.destroyHooks||(e.destroyHooks=[])).push(n,l)}}function It(e,t,n){Ot(e,t,3,n)}function At(e,t,n,r){(3&e[2])===n&&Ot(e,t,n,r)}function Dt(e,t){let n=e[2];(3&n)===t&&(n&=2047,n+=1,e[2]=n)}function Ot(e,t,n,r){const s=null!=r?r:-1,o=t.length-1;let i=0;for(let l=void 0!==r?65535&e[18]:0;l<o;l++)if("number"==typeof t[l+1]){if(i=t[l],null!=r&&i>=r)break}else t[l]<0&&(e[18]+=65536),(i<s||-1==s)&&(jt(e,n,t,l),e[18]=(4294901760&e[18])+l+2),l++}function jt(e,t,n,r){const s=n[r]<0,o=n[r+1],i=e[s?-n[r]:n[r]];if(s){if(e[2]>>11<e[18]>>16&&(3&e[2])===t){e[2]+=2048;try{o.call(i)}finally{}}}else try{o.call(i)}finally{}}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */class Ht{constructor(e,t,n){this.factory=e,this.resolving=!1,this.canSeeViewProviders=t,this.injectImpl=n}}function Pt(e,t,n){const r=Qe(e);let s=0;for(;s<n.length;){const o=n[s];if("number"==typeof o){if(0!==o)break;s++;const i=n[s++],l=n[s++],u=n[s++];r?e.setAttribute(t,l,u,i):t.setAttributeNS(i,l,u)}else{const i=o,l=n[++s];64===i.charCodeAt(0)?r&&e.setProperty(t,i,l):r?e.setAttribute(t,i,l):t.setAttribute(i,l),s++}}return s}function Rt(e,t){if(null===t||0===t.length);else if(null===e||0===e.length)e=t.slice();else{let n=-1;for(let r=0;r<t.length;r++){const s=t[r];"number"==typeof s?n=s:0===n||Nt(e,n,s,null,-1===n||2===n?t[++r]:null)}}return e}function Nt(e,t,n,r,s){let o=0,i=e.length;if(-1===t)i=-1;else for(;o<e.length;){const n=e[o++];if("number"==typeof n){if(n===t){i=-1;break}if(n>t){i=o-1;break}}}for(;o<e.length;){const t=e[o];if("number"==typeof t)break;if(t===n){if(null===r)return void(null!==s&&(e[o+1]=s));if(r===e[o+1])return void(e[o+2]=s)}o++,null!==r&&o++,null!==s&&o++}-1!==i&&(e.splice(i,0,t),o=i+1),e.splice(o++,0,n),null!==r&&e.splice(o++,0,r),null!==s&&e.splice(o++,0,s)}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */function Mt(e){return 32767&e}function Ft(e,t){let n=e>>16,r=t;for(;n>0;)r=r[15],n--;return r}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */let Vt=!0;function Lt(e){const t=Vt;return Vt=e,t}let Zt=0;function Bt(e,t){const n=zt(e,t);if(-1!==n)return n;const r=t[1];r.firstCreatePass&&(e.injectorIndex=t.length,$t(r.data,e),$t(t,null),$t(r.blueprint,null));const s=Ut(e,t),o=e.injectorIndex;if(-1!==s){const e=Mt(s),n=Ft(s,t),r=n[1].data;for(let s=0;s<8;s++)t[o+s]=n[e+s]|r[e+s]}return t[o+8]=s,o}function $t(e,t){e.push(0,0,0,0,0,0,0,0,t)}function zt(e,t){return-1===e.injectorIndex||e.parent&&e.parent.injectorIndex===e.injectorIndex||null===t[e.injectorIndex+8]?-1:e.injectorIndex}function Ut(e,t){if(e.parent&&-1!==e.parent.injectorIndex)return e.parent.injectorIndex;let n=0,r=null,s=t;for(;null!==s;){const e=s[1],t=e.type;if(r=2===t?e.declTNode:1===t?s[6]:null,null===r)return-1;if(n++,s=s[15],-1!==r.injectorIndex)return r.injectorIndex|n<<16}return-1}function Wt(e,t,n){!function(e,t,n){let r;"string"==typeof n?r=n.charCodeAt(0)||0:n.hasOwnProperty(De)&&(r=n[De]),null==r&&(r=n[De]=Zt++);const s=255&r;t.data[e+(s>>5)]|=1<<s}(e,t,n)}function Gt(e,t,n){if(n&ae.Optional)return e;ee(t,"NodeInjector")}function qt(e,t,n,r){if(n&ae.Optional&&void 0===r&&(r=null),0==(n&(ae.Self|ae.Host))){const s=e[9],o=de(void 0);try{return s?s.get(t,r,n&ae.Optional):fe(t,r,n&ae.Optional)}finally{de(o)}}return Gt(r,t,n)}const Qt={};function Jt(){return new tn(ct(),lt())}function Kt(e,t,n,r,s,o){const i=t[1],l=i.data[e+8],u=function(e,t,n,r,s){const o=e.providerIndexes,i=t.data,l=1048575&o,u=e.directiveStart,c=o>>20,a=s?l+c:e.directiveEnd;for(let h=r?l:l+c;h<a;h++){const e=i[h];if(h<u&&n===e||h>=u&&e.type===n)return h}if(s){const e=i[u];if(e&&Be(e)&&e.type===n)return u}return null}(l,i,n,null==r?function(e){return 2==(2&e.flags)}(l)&&Vt:r!=i&&0!=(3&l.type),s&ae.Host&&o===l);return null!==u?Yt(t,i,u,l):Qt}function Yt(e,t,n,r){let s=e[n];const o=t.data;if(s instanceof Ht){const i=s;i.resolving&&function(e,t){throw new Y("200",`Circular dependency in DI detected for ${e}`)}(X(o[n]));const l=Lt(i.canSeeViewProviders);i.resolving=!0;const u=i.injectImpl?de(i.injectImpl):null;vt(e,r,ae.Default);try{s=e[n]=i.factory(void 0,o,e,r),t.firstCreatePass&&n>=r.directiveStart&&
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */
function(e,t,n){const{ngOnChanges:r,ngOnInit:s,ngDoCheck:o}=t.type.prototype;if(r){const r=((i=t).type.prototype.ngOnChanges&&(i.setInput=We),Ue);(n.preOrderHooks||(n.preOrderHooks=[])).push(e,r),(n.preOrderCheckHooks||(n.preOrderCheckHooks=[])).push(e,r)}var i;s&&(n.preOrderHooks||(n.preOrderHooks=[])).push(0-e,s),o&&((n.preOrderHooks||(n.preOrderHooks=[])).push(e,o),(n.preOrderCheckHooks||(n.preOrderCheckHooks=[])).push(e,o))}(n,o[n],t)}finally{null!==u&&de(u),Lt(l),i.resolving=!1,xt()}}return s}function Xt(e,t,n){return!!(n[t+(e>>5)]&1<<e)}function en(e,t){return!(e&ae.Self||e&ae.Host&&t)}class tn{constructor(e,t){this._tNode=e,this._lView=t}get(e,t){return function(e,t,n,r=ae.Default,s){if(null!==e){const o=function(e){if("string"==typeof e)return e.charCodeAt(0)||0;const t=e.hasOwnProperty(De)?e[De]:void 0;return"number"==typeof t?t>=0?255&t:Jt:t}(n);if("function"==typeof o){if(!vt(t,e,r))return r&ae.Host?Gt(s,n,r):qt(t,n,r,s);try{const e=o();if(null!=e||r&ae.Optional)return e;ee(n)}finally{xt()}}else if("number"==typeof o){let s=null,i=zt(e,t),l=-1,u=r&ae.Host?t[16][6]:null;for((-1===i||r&ae.SkipSelf)&&(l=-1===i?Ut(e,t):t[i+8],-1!==l&&en(r,!1)?(s=t[1],i=Mt(l),t=Ft(l,t)):i=-1);-1!==i;){const e=t[1];if(Xt(o,i,e.data)){const e=Kt(i,t,n,s,r,u);if(e!==Qt)return e}l=t[i+8],-1!==l&&en(r,t[1].data[i+8]===u)&&Xt(o,i,t)?(s=e,i=Mt(l),t=Ft(l,t)):i=-1}}}return qt(t,n,r,s)}(this._tNode,this._lView,e,void 0,t)}}function nn(e,t,n){return pe(()=>{const r=function(e){return function(...t){if(e){const n=e(...t);for(const e in n)this[e]=n[e]}}}(t);function s(...e){if(this instanceof s)return r.apply(this,e),this;const t=new s(...e);return n.annotation=t,n;function n(e,n,r){const s=e.hasOwnProperty("__parameters__")?e.__parameters__:Object.defineProperty(e,"__parameters__",{value:[]}).__parameters__;for(;s.length<=r;)s.push(null);return(s[r]=s[r]||[]).push(t),e}}return n&&(s.prototype=Object.create(n.prototype)),s.prototype.ngMetadataName=e,s.annotationCls=s,s})}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */class rn{constructor(e,t){this._desc=e,this.ngMetadataName="InjectionToken",this.\u0275prov=void 0,"number"==typeof t?this.__NG_ELEMENT_ID__=t:void 0!==t&&(this.\u0275prov=te({token:this,providedIn:t.providedIn||"root",factory:t.factory}))}toString(){return`InjectionToken ${this._desc}`}}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */function sn(e,t){e.forEach(e=>Array.isArray(e)?sn(e,t):t(e))}function on(e,t){return t>=e.length-1?e.pop():e.splice(t,1)[0]}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */const ln={},un=/\n/gm,cn=W({provide:String,useValue:W});let an;function hn(e){const t=an;return an=e,t}function dn(e,t=ae.Default){if(void 0===an)throw new Error("inject() must be called from an injection context");return null===an?fe(e,void 0,t):an.get(e,t&ae.Optional?null:void 0,t)}function fn(e,t=ae.Default){return(he||dn)(K(e),t)}function pn(e){const t=[];for(let n=0;n<e.length;n++){const r=K(e[n]);if(Array.isArray(r)){if(0===r.length)throw new Error("Arguments array must have arguments.");let e,n=ae.Default;for(let t=0;t<r.length;t++){const s=r[t],o=s.__NG_DI_FLAG__;"number"==typeof o?-1===o?e=s.token:n|=o:e=s}t.push(fn(e,n))}else t.push(fn(r))}return t}function _n(e,t){return e.__NG_DI_FLAG__=t,e.prototype.__NG_DI_FLAG__=t,e}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */const yn=_n(nn("Inject",e=>({token:e})),-1),mn=_n(nn("Optional"),8),gn=_n(nn("SkipSelf"),4);function vn(e){return e.ngDebugContext}function bn(e){return e.ngOriginalError}function wn(e,...t){e.error(...t)}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */class Cn{constructor(){this._console=console}handleError(e){const t=this._findOriginalError(e),n=this._findContext(e),r=function(e){return e.ngErrorLogger||wn}(e);r(this._console,"ERROR",e),t&&r(this._console,"ORIGINAL ERROR",t),n&&r(this._console,"ERROR CONTEXT",n)}_findContext(e){return e?vn(e)?vn(e):this._findContext(bn(e)):null}_findOriginalError(e){let t=bn(e);for(;t&&bn(t);)t=bn(t);return t}}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */function En(e,t){e.__ngContext__=t}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */const xn=(()=>("undefined"!=typeof requestAnimationFrame&&requestAnimationFrame||setTimeout).bind(we))();function kn(e){return e instanceof Function?e():e}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */var Tn=function(e){return e[e.Important=1]="Important",e[e.DashCase=2]="DashCase",e}({});
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */function Sn(e,t){return(void 0)(e,t)}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */function In(e){const t=e[3];return Le(t)?t[3]:t}function An(e){return On(e[13])}function Dn(e){return On(e[4])}function On(e){for(;null!==e&&!Le(e);)e=e[4];return e}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */function jn(e,t,n,r,s){if(null!=r){let o,i=!1;Le(r)?o=r:Ve(r)&&(i=!0,r=r[0]);const l=Ke(r);0===e&&null!==n?null==s?Mn(t,n,l):Nn(t,n,l,s||null,!0):1===e&&null!==n?Nn(t,n,l,s||null,!0):2===e?function(e,t,n){const r=function(e,t){return Qe(e)?e.parentNode(t):t.parentNode}(e,t);r&&function(e,t,n,r){Qe(e)?e.removeChild(t,n,r):t.removeChild(n)}(e,r,t,n)}(t,l,i):3===e&&t.destroyNode(l),null!=o&&function(e,t,n,r,s){const o=n[7];o!==Ke(n)&&jn(t,e,r,o,s);for(let i=10;i<n.length;i++){const s=n[i];Bn(s[1],s,e,t,r,o)}}(t,e,o,n,s)}}function Hn(e,t,n){return Qe(e)?e.createElement(t,n):null===n?e.createElement(t):e.createElementNS(n,t)}function Pn(e,t){const n=e[9],r=n.indexOf(t),s=t[3];1024&t[2]&&(t[2]&=-1025,st(s,-1)),n.splice(r,1)}function Rn(e,t){if(!(256&t[2])){t[2]&=-129,t[2]|=256,function(e,t){let n;if(null!=e&&null!=(n=e.destroyHooks))for(let r=0;r<n.length;r+=2){const e=t[n[r]];if(!(e instanceof Ht)){const t=n[r+1];if(Array.isArray(t))for(let n=0;n<t.length;n+=2){const r=e[t[n]],s=t[n+1];try{s.call(r)}finally{}}else try{t.call(e)}finally{}}}}(e,t),function(e,t){const n=e.cleanup,r=t[7];let s=-1;if(null!==n)for(let o=0;o<n.length-1;o+=2)if("string"==typeof n[o]){const e=n[o+1],i="function"==typeof e?e(t):Ke(t[e]),l=r[s=n[o+2]],u=n[o+3];"boolean"==typeof u?i.removeEventListener(n[o],l,u):u>=0?r[s=u]():r[s=-u].unsubscribe(),o+=2}else{const e=r[s=n[o+1]];n[o].call(e)}if(null!==r){for(let e=s+1;e<r.length;e++)(0,r[e])();t[7]=null}}(e,t),1===t[1].type&&Qe(t[11])&&t[11].destroy();const n=t[17];if(null!==n&&Le(t[3])){n!==t[3]&&Pn(n,t);const r=t[19];null!==r&&r.detachView(e)}}}function Nn(e,t,n,r,s){Qe(e)?e.insertBefore(t,n,r,s):t.insertBefore(n,r,s)}function Mn(e,t,n){Qe(e)?e.appendChild(t,n):t.appendChild(n)}function Fn(e,t,n,r,s){null!==r?Nn(e,t,n,r,s):Mn(e,t,n)}function Vn(e,t,n,r){const s=function(e,t,n){return function(e,t,n){let r=t;for(;null!==r&&40&r.type;)r=(t=r).parent;if(null===r)return n[0];if(2&r.flags){const t=e.data[r.directiveStart].encapsulation;if(t===ye.None||t===ye.Emulated)return null}return Ye(r,n)}(e,t.parent,n)}(e,r,t),o=t[11],i=function(e,t,n){return function(e,t,n){return 40&e.type?Ye(e,n):null}(e,0,n)}(r.parent||t[6],0,t);if(null!=s)if(Array.isArray(n))for(let l=0;l<n.length;l++)Fn(o,s,n[l],i,!1);else Fn(o,s,n,i,!1)}function Ln(e,t){return null!==t?e[16][6].projection[t.projection]:null}function Zn(e,t,n,r,s,o,i){for(;null!=n;){const l=r[n.index],u=n.type;if(i&&0===t&&(l&&En(Ke(l),r),n.flags|=4),64!=(64&n.flags))if(8&u)Zn(e,t,n.child,r,s,o,!1),jn(t,e,s,l,o);else if(32&u){const i=Sn(n,r);let u;for(;u=i();)jn(t,e,s,u,o);jn(t,e,s,l,o)}else 16&u?$n(e,t,r,n,s,o):jn(t,e,s,l,o);n=i?n.projectionNext:n.next}}function Bn(e,t,n,r,s,o){Zn(n,r,e.firstChild,t,s,o,!1)}function $n(e,t,n,r,s,o){const i=n[16],l=i[6].projection[r.projection];if(Array.isArray(l))for(let u=0;u<l.length;u++)jn(t,e,s,l[u],o);else Zn(e,t,l,i[3],s,o,!0)}function zn(e,t,n){Qe(e)?e.setAttribute(t,"style",n):t.style.cssText=n}function Un(e,t,n){Qe(e)?""===n?e.removeAttribute(t,"class"):e.setAttribute(t,"class",n):t.className=n}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */function Wn(e,t,n){let r=e.length;for(;;){const s=e.indexOf(t,n);if(-1===s)return s;if(0===s||e.charCodeAt(s-1)<=32){const n=t.length;if(s+n===r||e.charCodeAt(s+n)<=32)return s}n=s+1}}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */function Gn(e,t,n){let r=0;for(;r<e.length;){let s=e[r++];if(n&&"class"===s){if(s=e[r],-1!==Wn(s.toLowerCase(),t,0))return!0}else if(1===s){for(;r<e.length&&"string"==typeof(s=e[r++]);)if(s.toLowerCase()===t)return!0;return!1}}return!1}function qn(e){return 4===e.type&&"ng-template"!==e.value}function Qn(e,t,n){return t===(4!==e.type||n?e.value:"ng-template")}function Jn(e,t,n){let r=4;const s=e.attrs||[],o=function(e){for(let n=0;n<e.length;n++)if(3===(t=e[n])||4===t||6===t)return n;var t;return e.length}(s);let i=!1;for(let l=0;l<t.length;l++){const u=t[l];if("number"!=typeof u){if(!i)if(4&r){if(r=2|1&r,""!==u&&!Qn(e,u,n)||""===u&&1===t.length){if(Kn(r))return!1;i=!0}}else{const c=8&r?u:t[++l];if(8&r&&null!==e.attrs){if(!Gn(e.attrs,c,n)){if(Kn(r))return!1;i=!0}continue}const a=Yn(8&r?"class":u,s,qn(e),n);if(-1===a){if(Kn(r))return!1;i=!0;continue}if(""!==c){let e;e=a>o?"":s[a+1].toLowerCase();const t=8&r?e:null;if(t&&-1!==Wn(t,c,0)||2&r&&c!==e){if(Kn(r))return!1;i=!0}}}}else{if(!i&&!Kn(r)&&!Kn(u))return!1;if(i&&Kn(u))continue;i=!1,r=u|1&r}}return Kn(r)||i}function Kn(e){return 0==(1&e)}function Yn(e,t,n,r){if(null===t)return-1;let s=0;if(r||!n){let n=!1;for(;s<t.length;){const r=t[s];if(r===e)return s;if(3===r||6===r)n=!0;else{if(1===r||2===r){let e=t[++s];for(;"string"==typeof e;)e=t[++s];continue}if(4===r)break;if(0===r){s+=4;continue}}s+=n?1:2}return-1}return function(e,t){let n=e.indexOf(4);if(n>-1)for(n++;n<e.length;){const r=e[n];if("number"==typeof r)return-1;if(r===t)return n;n++}return-1}(t,e)}function Xn(e,t,n=!1){for(let r=0;r<t.length;r++)if(Jn(e,t[r],n))return!0;return!1}function er(e,t){return e?":not("+t.trim()+")":t}function tr(e){let t=e[0],n=1,r=2,s="",o=!1;for(;n<e.length;){let i=e[n];if("string"==typeof i)if(2&r){const t=e[++n];s+="["+i+(t.length>0?'="'+t+'"':"")+"]"}else 8&r?s+="."+i:4&r&&(s+=" "+i);else""===s||Kn(i)||(t+=er(o,s),s=""),r=i,o=o||!Kn(r);n++}return""!==s&&(t+=er(o,s)),t}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */const nr={};
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */function rr(e,t){const n=e.contentQueries;if(null!==n)for(let r=0;r<n.length;r+=2){const s=n[r],o=n[r+1];if(-1!==o){const n=e.data[o];mt(s),n.contentQueries(2,t[o],o)}}}function sr(e,t,n,r,s,o,i,l,u,c){const a=t.blueprint.slice();return a[0]=s,a[2]=140|r,rt(a),a[3]=a[15]=e,a[8]=n,a[10]=i||e&&e[10],a[11]=l||e&&e[11],a[12]=u||e&&e[12]||null,a[9]=c||e&&e[9]||null,a[6]=o,a[16]=2==t.type?e[16]:a,a}function or(e,t,n,r,s){let o=e.data[t];if(null===o)o=function(e,t,n,r,s){const o=at(),i=dt(),l=e.data[t]=function(e,t,n,r,s,o){return{type:n,index:r,insertBeforeIndex:null,injectorIndex:t?t.injectorIndex:-1,directiveStart:-1,directiveEnd:-1,directiveStylingLast:-1,propertyBindings:null,flags:0,providerIndexes:0,value:s,attrs:o,mergedAttrs:null,localNames:null,initialInputs:void 0,inputs:null,outputs:null,tViews:null,next:null,projectionNext:null,child:null,parent:t,projection:null,styles:null,stylesWithoutHost:null,residualStyles:void 0,classes:null,classesWithoutHost:null,residualClasses:void 0,classBindings:0,styleBindings:0}}(0,i?o:o&&o.parent,n,t,r,s);return null===e.firstChild&&(e.firstChild=l),null!==o&&(i?null==o.child&&null!==l.parent&&(o.child=l):null===o.next&&(o.next=l)),l}(e,t,n,r,s),ot.lFrame.inI18n&&(o.flags|=64);else if(64&o.type){o.type=n,o.value=r,o.attrs=s;const e=function(){const e=ot.lFrame,t=e.currentTNode;return e.isParent?t:t.parent}();o.injectorIndex=null===e?-1:e.injectorIndex}return ht(o,!0),o}function ir(e,t,n,r){if(0===n)return-1;const s=t.length;for(let o=0;o<n;o++)t.push(r),e.blueprint.push(r),e.data.push(null);return s}function lr(e,t,n){bt(t);try{const r=e.viewQuery;null!==r&&Ar(1,r,n);const s=e.template;null!==s&&ar(e,t,s,1,n),e.firstCreatePass&&(e.firstCreatePass=!1),e.staticContentQueries&&rr(e,t),e.staticViewQueries&&Ar(2,e.viewQuery,n);const o=e.components;null!==o&&function(e,t){for(let n=0;n<t.length;n++)kr(e,t[n])}(t,o)}catch(r){throw e.firstCreatePass&&(e.incompleteFirstPass=!0),r}finally{t[2]&=-5,kt()}}function ur(e,t,n,r){const s=t[2];if(256==(256&s))return;bt(t);const o=ft();try{rt(t),ot.lFrame.bindingIndex=e.bindingStartIndex,null!==n&&ar(e,t,n,2,r);const i=3==(3&s);if(!o)if(i){const n=e.preOrderCheckHooks;null!==n&&It(t,n,null)}else{const n=e.preOrderHooks;null!==n&&At(t,n,0,null),Dt(t,0)}if(function(e){for(let t=An(e);null!==t;t=Dn(t)){if(!t[2])continue;const e=t[9];for(let t=0;t<e.length;t++){const n=e[t],r=n[3];0==(1024&n[2])&&st(r,1),n[2]|=1024}}}(t),function(e){for(let t=An(e);null!==t;t=Dn(t))for(let e=10;e<t.length;e++){const n=t[e],r=n[1];tt(n)&&ur(r,n,r.template,n[8])}}(t),null!==e.contentQueries&&rr(e,t),!o)if(i){const n=e.contentCheckHooks;null!==n&&It(t,n)}else{const n=e.contentHooks;null!==n&&At(t,n,1),Dt(t,1)}!function(e,t){const n=e.hostBindingOpCodes;if(null!==n)try{for(let e=0;e<n.length;e++){const r=n[e];if(r<0)Tt(~r);else{const s=r,o=n[++e],i=n[++e];_t(o,s),i(2,t[s])}}}finally{Tt(-1)}}(e,t);const l=e.components;null!==l&&function(e,t){for(let n=0;n<t.length;n++)Er(e,t[n])}(t,l);const u=e.viewQuery;if(null!==u&&Ar(2,u,r),!o)if(i){const n=e.viewCheckHooks;null!==n&&It(t,n)}else{const n=e.viewHooks;null!==n&&At(t,n,2),Dt(t,2)}!0===e.firstUpdatePass&&(e.firstUpdatePass=!1),o||(t[2]&=-73),1024&t[2]&&(t[2]&=-1025,st(t[3],-1))}finally{kt()}}function cr(e,t,n,r){const s=t[10],o=!ft(),i=4==(4&t[2]);try{o&&!i&&s.begin&&s.begin(),i&&lr(e,t,r),ur(e,t,n,r)}finally{o&&!i&&s.end&&s.end()}}function ar(e,t,n,r,s){const o=ot.lFrame.selectedIndex,i=2&r;try{Tt(-1),i&&t.length>20&&function(e,t,n,r){if(!r)if(3==(3&t[2])){const n=e.preOrderCheckHooks;null!==n&&It(t,n,20)}else{const n=e.preOrderHooks;null!==n&&At(t,n,0,20)}Tt(20)}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */(e,t,0,ft()),n(r,s)}finally{Tt(o)}}function hr(e){const t=e.tView;return null===t||t.incompleteFirstPass?e.tView=dr(1,null,e.template,e.decls,e.vars,e.directiveDefs,e.pipeDefs,e.viewQuery,e.schemas,e.consts):t}function dr(e,t,n,r,s,o,i,l,u,c){const a=20+r,h=a+s,d=function(e,t){const n=[];for(let r=0;r<t;r++)n.push(r<e?null:nr);return n}(a,h),f="function"==typeof c?c():c;return d[1]={type:e,blueprint:d,template:n,queries:null,viewQuery:l,declTNode:t,data:d.slice().fill(null,a),bindingStartIndex:a,expandoStartIndex:h,hostBindingOpCodes:null,firstCreatePass:!0,firstUpdatePass:!0,staticViewQueries:!1,staticContentQueries:!1,preOrderHooks:null,preOrderCheckHooks:null,contentHooks:null,contentCheckHooks:null,viewHooks:null,viewCheckHooks:null,destroyHooks:null,cleanup:null,contentQueries:null,components:null,directiveRegistry:"function"==typeof o?o():o,pipeRegistry:"function"==typeof i?i():i,firstChild:null,schemas:u,consts:f,incompleteFirstPass:!1}}function fr(e,t,n){for(let r in e)if(e.hasOwnProperty(r)){const s=e[r];(n=null===n?{}:n).hasOwnProperty(r)?n[r].push(t,s):n[r]=[t,s]}return n}function pr(e,t,n,r,s,o){const i=o.hostBindings;if(i){let n=e.hostBindingOpCodes;null===n&&(n=e.hostBindingOpCodes=[]);const o=~t.index;(function(e){let t=e.length;for(;t>0;){const n=e[--t];if("number"==typeof n&&n<0)return n}return 0})(n)!=o&&n.push(o),n.push(r,s,i)}}function _r(e,t){null!==e.hostBindings&&e.hostBindings(1,t)}function yr(e,t){t.flags|=2,(e.components||(e.components=[])).push(t.index)}function mr(e,t,n){if(n){if(t.exportAs)for(let r=0;r<t.exportAs.length;r++)n[t.exportAs[r]]=e;Be(t)&&(n[""]=e)}}function gr(e,t,n){e.flags|=1,e.directiveStart=t,e.directiveEnd=t+n,e.providerIndexes=t}function vr(e,t,n,r,s){e.data[r]=s;const o=s.factory||(s.factory=$e(s.type)),i=new Ht(o,Be(s),null);e.blueprint[r]=i,n[r]=i,pr(e,t,0,r,ir(e,n,s.hostVars,nr),s)}function br(e,t,n){const r=Ye(t,e),s=hr(n),o=e[10],i=Tr(e,sr(e,s,null,n.onPush?64:16,r,t,o,o.createRenderer(r,n),null,null));e[t.index]=i}function wr(e,t,n,r,s,o){const i=o[t];if(null!==i){const e=r.setInput;for(let t=0;t<i.length;){const s=i[t++],o=i[t++],l=i[t++];null!==e?r.setInput(n,l,s,o):n[o]=l}}}function Cr(e,t){let n=null,r=0;for(;r<t.length;){const s=t[r];if(0!==s)if(5!==s){if("number"==typeof s)break;e.hasOwnProperty(s)&&(null===n&&(n=[]),n.push(s,e[s],t[r+1])),r+=2}else r+=2;else r+=4}return n}function Er(e,t){const n=Xe(t,e);if(tt(n)){const e=n[1];80&n[2]?ur(e,n,e.template,n[8]):n[5]>0&&xr(n)}}function xr(e){for(let n=An(e);null!==n;n=Dn(n))for(let e=10;e<n.length;e++){const t=n[e];if(1024&t[2]){const e=t[1];ur(e,t,e.template,t[8])}else t[5]>0&&xr(t)}const t=e[1].components;if(null!==t)for(let n=0;n<t.length;n++){const r=Xe(t[n],e);tt(r)&&r[5]>0&&xr(r)}}function kr(e,t){const n=Xe(t,e),r=n[1];!function(e,t){for(let n=t.length;n<e.blueprint.length;n++)t.push(e.blueprint[n])}(r,n),lr(r,n,n[8])}function Tr(e,t){return e[13]?e[14][4]=t:e[13]=t,e[14]=t,t}function Sr(e,t,n){const r=t[10];r.begin&&r.begin();try{ur(e,t,e.template,n)}catch(s){throw function(e,t){const n=e[9],r=n?n.get(Cn,null):null;r&&r.handleError(t)}(t,s),s}finally{r.end&&r.end()}}function Ir(e){!function(e){for(let t=0;t<e.components.length;t++){const n=e.components[t],r=et(n),s=r[1];cr(s,r,s.template,n)}}(e[8])}function Ar(e,t,n){mt(0),t(e,n)}const Dr=(()=>Promise.resolve(null))();
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */function Or(e,t,n){let r=n?e.styles:null,s=n?e.classes:null,o=0;if(null!==t)for(let i=0;i<t.length;i++){const e=t[i];"number"==typeof e?o=e:1==o?s=q(s,e):2==o&&(r=q(r,e+": "+t[++i]+";"))}n?e.styles=r:e.stylesWithoutHost=r,n?e.classes=s:e.classesWithoutHost=s}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */const jr=new rn("INJECTOR",-1);
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */class Hr{get(e,t=ln){if(t===ln){const t=new Error(`NullInjectorError: No provider for ${G(e)}!`);throw t.name="NullInjectorError",t}return t}}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */const Pr=new rn("Set Injector scope."),Rr={},Nr={},Mr=[];
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */let Fr;function Vr(){return void 0===Fr&&(Fr=new Hr),Fr}function Lr(e,t=null,n=null,r){return new Zr(e,n,t||Vr(),r)}class Zr{constructor(e,t,n,r=null){this.parent=n,this.records=new Map,this.injectorDefTypes=new Set,this.onDestroy=new Set,this._destroyed=!1;const s=[];t&&sn(t,n=>this.processProvider(n,e,t)),sn([e],e=>this.processInjectorType(e,[],s)),this.records.set(jr,$r(void 0,this));const o=this.records.get(Pr);this.scope=null!=o?o.value:null,this.source=r||("object"==typeof e?null:G(e))}get destroyed(){return this._destroyed}destroy(){this.assertNotDestroyed(),this._destroyed=!0;try{this.onDestroy.forEach(e=>e.ngOnDestroy())}finally{this.records.clear(),this.onDestroy.clear(),this.injectorDefTypes.clear()}}get(e,t=ln,n=ae.Default){this.assertNotDestroyed();const r=hn(this);try{if(!(n&ae.SkipSelf)){let t=this.records.get(e);if(void 0===t){const n=("function"==typeof(s=e)||"object"==typeof s&&s instanceof rn)&&re(e);t=n&&this.injectableDefInScope(n)?$r(Br(e),Rr):null,this.records.set(e,t)}if(null!=t)return this.hydrate(e,t)}return(n&ae.Self?Vr():this.parent).get(e,t=n&ae.Optional&&t===ln?null:t)}catch(o){if("NullInjectorError"===o.name){if((o.ngTempTokenPath=o.ngTempTokenPath||[]).unshift(G(e)),r)throw o;return function(e,t,n,r){const s=e.ngTempTokenPath;throw t.__source&&s.unshift(t.__source),e.message=function(e,t,n,r=null){e=e&&"\n"===e.charAt(0)&&"\u0275"==e.charAt(1)?e.substr(2):e;let s=G(t);if(Array.isArray(t))s=t.map(G).join(" -> ");else if("object"==typeof t){let e=[];for(let n in t)if(t.hasOwnProperty(n)){let r=t[n];e.push(n+":"+("string"==typeof r?JSON.stringify(r):G(r)))}s=`{${e.join(", ")}}`}return`${n}${r?"("+r+")":""}[${s}]: ${e.replace(un,"\n  ")}`}("\n"+e.message,s,n,r),e.ngTokenPath=s,e.ngTempTokenPath=null,e}(o,e,"R3InjectorError",this.source)}throw o}finally{hn(r)}var s;
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */}_resolveInjectorDefTypes(){this.injectorDefTypes.forEach(e=>this.get(e))}toString(){const e=[];return this.records.forEach((t,n)=>e.push(G(n))),`R3Injector[${e.join(", ")}]`}assertNotDestroyed(){if(this._destroyed)throw new Error("Injector has already been destroyed.")}processInjectorType(e,t,n){if(!(e=K(e)))return!1;let r=oe(e);const s=null==r&&e.ngModule||void 0,o=void 0===s?e:s,i=-1!==n.indexOf(o);if(void 0!==s&&(r=oe(s)),null==r)return!1;if(null!=r.imports&&!i){let e;n.push(o);try{sn(r.imports,r=>{this.processInjectorType(r,t,n)&&(void 0===e&&(e=[]),e.push(r))})}finally{}if(void 0!==e)for(let t=0;t<e.length;t++){const{ngModule:n,providers:r}=e[t];sn(r,e=>this.processProvider(e,n,r||Mr))}}this.injectorDefTypes.add(o);const l=$e(o)||(()=>new o);this.records.set(o,$r(l,Rr));const u=r.providers;if(null!=u&&!i){const t=e;sn(u,e=>this.processProvider(e,t,u))}return void 0!==s&&void 0!==e.providers}processProvider(e,t,n){let r=Ur(e=K(e))?e:K(e&&e.provide);const s=function(e,t,n){return zr(e)?$r(void 0,e.useValue):$r(function(e,t,n){let r;if(Ur(e)){const t=K(e);return $e(t)||Br(t)}if(zr(e))r=()=>K(e.useValue);else if((s=e)&&s.useFactory)r=()=>e.useFactory(...pn(e.deps||[]));else if(function(e){return!(!e||!e.useExisting)}(e))r=()=>fn(K(e.useExisting));else{const t=K(e&&(e.useClass||e.provide));if(!function(e){return!!e.deps}(e))return $e(t)||Br(t);r=()=>new t(...pn(e.deps))}var s;return r}(e),Rr)}(e);if(Ur(e)||!0!==e.multi)this.records.get(r);else{let t=this.records.get(r);t||(t=$r(void 0,Rr,!0),t.factory=()=>pn(t.multi),this.records.set(r,t)),r=e,t.multi.push(e)}this.records.set(r,s)}hydrate(e,t){var n;return t.value===Rr&&(t.value=Nr,t.value=t.factory()),"object"==typeof t.value&&t.value&&null!==(n=t.value)&&"object"==typeof n&&"function"==typeof n.ngOnDestroy&&this.onDestroy.add(t.value),t.value}injectableDefInScope(e){return!!e.providedIn&&("string"==typeof e.providedIn?"any"===e.providedIn||e.providedIn===this.scope:this.injectorDefTypes.has(e.providedIn))}}function Br(e){const t=re(e),n=null!==t?t.factory:$e(e);if(null!==n)return n;if(e instanceof rn)throw new Error(`Token ${G(e)} is missing a \u0275prov definition.`);if(e instanceof Function)return function(e){const t=e.length;if(t>0){const n=function(e,t){const n=[];for(let r=0;r<e;r++)n.push("?");return n}(t);throw new Error(`Can't resolve all parameters for ${G(e)}: (${n.join(", ")}).`)}const n=function(e){const t=e&&(e[ie]||e[ue]);if(t){const n=function(e){if(e.hasOwnProperty("name"))return e.name;const t=(""+e).match(/^function\s*([^\s(]+)/);return null===t?"":t[1]}(e);return console.warn(`DEPRECATED: DI is instantiating a token "${n}" that inherits its @Injectable decorator but does not provide one itself.\nThis will become an error in a future version of Angular. Please add @Injectable() to the "${n}" class.`),t}return null}(e);return null!==n?()=>n.factory(e):()=>new e}(e);throw new Error("unreachable")}function $r(e,t,n=!1){return{factory:e,value:t,multi:n?[]:void 0}}function zr(e){return null!==e&&"object"==typeof e&&cn in e}function Ur(e){return"function"==typeof e}const Wr=function(e,t,n){return function(e,t=null,n=null,r){const s=Lr(e,t,n,r);return s._resolveInjectorDefTypes(),s}({name:n},t,e,n)};let Gr=(()=>{class e{static create(e,t){return Array.isArray(e)?Wr(e,t,""):Wr(e.providers,e.parent,e.name||"")}}return e.THROW_IF_NOT_FOUND=ln,e.NULL=new Hr,e.\u0275prov=te({token:e,providedIn:"any",factory:()=>fn(jr)}),e.__NG_ELEMENT_ID__=-1,e})();function qr(e,t){St(et(e)[1],ct())}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */let Qr=null;function Jr(){if(!Qr){const e=we.Symbol;if(e&&e.iterator)Qr=e.iterator;else{const e=Object.getOwnPropertyNames(Map.prototype);for(let t=0;t<e.length;++t){const n=e[t];"entries"!==n&&"size"!==n&&Map.prototype[n]===Map.prototype.entries&&(Qr=n)}}}return Qr}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */function Kr(e){return!!Yr(e)&&(Array.isArray(e)||!(e instanceof Map)&&Jr()in e)}function Yr(e){return null!==e&&("function"==typeof e||"object"==typeof e)}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */function Xr(e,t,n,r,s){const o=s?"class":"style";!function(e,t,n,r,s){for(let o=0;o<n.length;){const i=n[o++],l=n[o++],u=t[i],c=e.data[i];null!==c.setInput?c.setInput(u,s,r,l):u[l]=s}}(e,n,t.inputs[o],o,r)}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */function es(e,t,n,r){const s=lt(),o=ut(),i=20+e,l=s[11],u=s[i]=Hn(l,t,ot.lFrame.currentNamespace),c=o.firstCreatePass?function(e,t,n,r,s,o,i){const l=t.consts,u=or(t,e,2,s,nt(l,o));return function(e,t,n,r){let s=!1;if(it()){const o=function(e,t,n){const r=e.directiveRegistry;let s=null;if(r)for(let o=0;o<r.length;o++){const i=r[o];Xn(n,i.selectors,!1)&&(s||(s=[]),Wt(Bt(n,t),e,i.type),Be(i)?(yr(e,n),s.unshift(i)):s.push(i))}return s}(e,t,n),i=null===r?null:{"":-1};if(null!==o){s=!0,gr(n,e.data.length,o.length);for(let e=0;e<o.length;e++){const t=o[e];t.providersResolver&&t.providersResolver(t)}let r=!1,l=!1,u=ir(e,t,o.length,null);for(let s=0;s<o.length;s++){const c=o[s];n.mergedAttrs=Rt(n.mergedAttrs,c.hostAttrs),vr(e,n,t,u,c),mr(u,c,i),null!==c.contentQueries&&(n.flags|=8),null===c.hostBindings&&null===c.hostAttrs&&0===c.hostVars||(n.flags|=128);const a=c.type.prototype;!r&&(a.ngOnChanges||a.ngOnInit||a.ngDoCheck)&&((e.preOrderHooks||(e.preOrderHooks=[])).push(n.index),r=!0),l||!a.ngOnChanges&&!a.ngDoCheck||((e.preOrderCheckHooks||(e.preOrderCheckHooks=[])).push(n.index),l=!0),u++}!function(e,t){const n=t.directiveEnd,r=e.data,s=t.attrs,o=[];let i=null,l=null;for(let u=t.directiveStart;u<n;u++){const e=r[u],n=e.inputs,c=null===s||qn(t)?null:Cr(n,s);o.push(c),i=fr(n,u,i),l=fr(e.outputs,u,l)}null!==i&&(i.hasOwnProperty("class")&&(t.flags|=16),i.hasOwnProperty("style")&&(t.flags|=32)),t.initialInputs=o,t.inputs=i,t.outputs=l}(e,n)}i&&function(e,t,n){if(t){const r=e.localNames=[];for(let e=0;e<t.length;e+=2){const s=n[t[e+1]];if(null==s)throw new Y("301",`Export of name '${t[e+1]}' not found!`);r.push(t[e],s)}}}(n,r,i)}n.mergedAttrs=Rt(n.mergedAttrs,n.attrs)}(t,n,u,nt(l,i)),null!==u.attrs&&Or(u,u.attrs,!1),null!==u.mergedAttrs&&Or(u,u.mergedAttrs,!0),null!==t.queries&&t.queries.elementStart(t,u),u}(i,o,s,0,t,n,r):o.data[i];ht(c,!0);const a=c.mergedAttrs;null!==a&&Pt(l,u,a);const h=c.classes;null!==h&&Un(l,u,h);const d=c.styles;null!==d&&zn(l,u,d),64!=(64&c.flags)&&Vn(o,s,u,c),0===ot.lFrame.elementDepthCount&&En(u,s),ot.lFrame.elementDepthCount++,function(e){return 1==(1&e.flags)}(c)&&(function(e,t,n){it()&&(function(e,t,n,r){const s=n.directiveStart,o=n.directiveEnd;e.firstCreatePass||Bt(n,t),En(r,t);const i=n.initialInputs;for(let l=s;l<o;l++){const r=e.data[l],o=Be(r);o&&br(t,n,r);const u=Yt(t,e,l,n);En(u,t),null!==i&&wr(0,l-s,u,r,0,i),o&&(Xe(n.index,t)[8]=u)}}(e,t,n,Ye(n,t)),128==(128&n.flags)&&function(e,t,n){const r=n.directiveStart,s=n.directiveEnd,o=n.index,i=ot.lFrame.currentDirectiveIndex;try{Tt(o);for(let n=r;n<s;n++){const r=e.data[n],s=t[n];yt(n),null===r.hostBindings&&0===r.hostVars&&null===r.hostAttrs||_r(r,s)}}finally{Tt(-1),yt(i)}}(e,t,n))}(o,s,c),function(e,t,n){if(Ze(t)){const r=t.directiveEnd;for(let s=t.directiveStart;s<r;s++){const t=e.data[s];t.contentQueries&&t.contentQueries(1,n[s],s)}}}(o,c,s)),null!==r&&function(e,t,n=Ye){const r=t.localNames;if(null!==r){let s=t.index+1;for(let o=0;o<r.length;o+=2){const i=r[o+1],l=-1===i?n(t,e):e[i];e[s++]=l}}}(s,c)}function ts(){let e=ct();dt()?ot.lFrame.isParent=!1:(e=e.parent,ht(e,!1));const t=e;ot.lFrame.elementDepthCount--;const n=ut();n.firstCreatePass&&(St(n,e),Ze(e)&&n.queries.elementEnd(e)),null!=t.classesWithoutHost&&function(e){return 0!=(16&e.flags)}(t)&&Xr(n,t,lt(),t.classesWithoutHost,!0),null!=t.stylesWithoutHost&&function(e){return 0!=(32&e.flags)}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */(t)&&Xr(n,t,lt(),t.stylesWithoutHost,!1)}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */function ns(e){return!!e&&"function"==typeof e.then}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */function rs(e,t=""){const n=lt(),r=ut(),s=e+20,o=r.firstCreatePass?or(r,s,1,t,null):r.data[s],i=n[s]=function(e,t){return Qe(e)?e.createText(t):e.createTextNode(t)}(n[11],t);Vn(r,n,i,o),ht(o,!1)}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */const ss=void 0;var os=["en",[["a","p"],["AM","PM"],ss],[["AM","PM"],ss,ss],[["S","M","T","W","T","F","S"],["Sun","Mon","Tue","Wed","Thu","Fri","Sat"],["Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"],["Su","Mo","Tu","We","Th","Fr","Sa"]],ss,[["J","F","M","A","M","J","J","A","S","O","N","D"],["Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"],["January","February","March","April","May","June","July","August","September","October","November","December"]],ss,[["B","A"],["BC","AD"],["Before Christ","Anno Domini"]],0,[6,0],["M/d/yy","MMM d, y","MMMM d, y","EEEE, MMMM d, y"],["h:mm a","h:mm:ss a","h:mm:ss a z","h:mm:ss a zzzz"],["{1}, {0}",ss,"{1} 'at' {0}",ss],[".",",",";","%","+","-","E","\xd7","\u2030","\u221e","NaN",":"],["#,##0.###","#,##0%","\xa4#,##0.00","#E0"],"USD","$","US Dollar",{},"ltr",function(e){let t=Math.floor(Math.abs(e)),n=e.toString().replace(/^[^.]*\.?/,"").length;return 1===t&&0===n?1:5}];
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */let is={};function ls(e){return e in is||(is[e]=we.ng&&we.ng.common&&we.ng.common.locales&&we.ng.common.locales[e]),is[e]}var us=function(e){return e[e.LocaleId=0]="LocaleId",e[e.DayPeriodsFormat=1]="DayPeriodsFormat",e[e.DayPeriodsStandalone=2]="DayPeriodsStandalone",e[e.DaysFormat=3]="DaysFormat",e[e.DaysStandalone=4]="DaysStandalone",e[e.MonthsFormat=5]="MonthsFormat",e[e.MonthsStandalone=6]="MonthsStandalone",e[e.Eras=7]="Eras",e[e.FirstDayOfWeek=8]="FirstDayOfWeek",e[e.WeekendRange=9]="WeekendRange",e[e.DateFormat=10]="DateFormat",e[e.TimeFormat=11]="TimeFormat",e[e.DateTimeFormat=12]="DateTimeFormat",e[e.NumberSymbols=13]="NumberSymbols",e[e.NumberFormats=14]="NumberFormats",e[e.CurrencyCode=15]="CurrencyCode",e[e.CurrencySymbol=16]="CurrencySymbol",e[e.CurrencyName=17]="CurrencyName",e[e.Currencies=18]="Currencies",e[e.Directionality=19]="Directionality",e[e.PluralCase=20]="PluralCase",e[e.ExtraData=21]="ExtraData",e}({});
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */let cs="en-US";function as(e){var t,n;n="Expected localeId to be defined",null==(t=e)&&function(e,t,n,r){throw new Error(`ASSERTION ERROR: ${e} [Expected=> null != ${t} <=Actual]`)}(n,t),"string"==typeof e&&(cs=e.toLowerCase().replace(/_/g,"-"))}class hs{}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */class ds{resolveComponentFactory(e){throw function(e){const t=Error(`No component factory found for ${G(e)}. Did you add it to @NgModule.entryComponents?`);return t.ngComponent=e,t}(e)}}let fs=(()=>{class e{}return e.NULL=new ds,e})();
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */function ps(...e){}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */function _s(e,t){return new ms(Ye(e,t))}const ys=function(){return _s(ct(),lt())};let ms=(()=>{class e{constructor(e){this.nativeElement=e}}return e.__NG_ELEMENT_ID__=ys,e})();class gs{}let vs=(()=>{class e{}return e.\u0275prov=te({token:e,providedIn:"root",factory:()=>null}),e})();
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */class bs{constructor(e){this.full=e,this.major=e.split(".")[0],this.minor=e.split(".")[1],this.patch=e.split(".").slice(2).join(".")}}const ws=new bs("11.2.14");
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */class Cs{constructor(){}supports(e){return Kr(e)}create(e){return new xs(e)}}const Es=(e,t)=>t;class xs{constructor(e){this.length=0,this._linkedRecords=null,this._unlinkedRecords=null,this._previousItHead=null,this._itHead=null,this._itTail=null,this._additionsHead=null,this._additionsTail=null,this._movesHead=null,this._movesTail=null,this._removalsHead=null,this._removalsTail=null,this._identityChangesHead=null,this._identityChangesTail=null,this._trackByFn=e||Es}forEachItem(e){let t;for(t=this._itHead;null!==t;t=t._next)e(t)}forEachOperation(e){let t=this._itHead,n=this._removalsHead,r=0,s=null;for(;t||n;){const o=!n||t&&t.currentIndex<Is(n,r,s)?t:n,i=Is(o,r,s),l=o.currentIndex;if(o===n)r--,n=n._nextRemoved;else if(t=t._next,null==o.previousIndex)r++;else{s||(s=[]);const e=i-r,t=l-r;if(e!=t){for(let n=0;n<e;n++){const r=n<s.length?s[n]:s[n]=0,o=r+n;t<=o&&o<e&&(s[n]=r+1)}s[o.previousIndex]=t-e}}i!==l&&e(o,i,l)}}forEachPreviousItem(e){let t;for(t=this._previousItHead;null!==t;t=t._nextPrevious)e(t)}forEachAddedItem(e){let t;for(t=this._additionsHead;null!==t;t=t._nextAdded)e(t)}forEachMovedItem(e){let t;for(t=this._movesHead;null!==t;t=t._nextMoved)e(t)}forEachRemovedItem(e){let t;for(t=this._removalsHead;null!==t;t=t._nextRemoved)e(t)}forEachIdentityChange(e){let t;for(t=this._identityChangesHead;null!==t;t=t._nextIdentityChange)e(t)}diff(e){if(null==e&&(e=[]),!Kr(e))throw new Error(`Error trying to diff '${G(e)}'. Only arrays and iterables are allowed`);return this.check(e)?this:null}onDestroy(){}check(e){this._reset();let t,n,r,s=this._itHead,o=!1;if(Array.isArray(e)){this.length=e.length;for(let t=0;t<this.length;t++)n=e[t],r=this._trackByFn(t,n),null!==s&&Object.is(s.trackById,r)?(o&&(s=this._verifyReinsertion(s,n,r,t)),Object.is(s.item,n)||this._addIdentityChange(s,n)):(s=this._mismatch(s,n,r,t),o=!0),s=s._next}else t=0,function(e,t){if(Array.isArray(e))for(let n=0;n<e.length;n++)t(e[n]);else{const n=e[Jr()]();let r;for(;!(r=n.next()).done;)t(r.value)}}(e,e=>{r=this._trackByFn(t,e),null!==s&&Object.is(s.trackById,r)?(o&&(s=this._verifyReinsertion(s,e,r,t)),Object.is(s.item,e)||this._addIdentityChange(s,e)):(s=this._mismatch(s,e,r,t),o=!0),s=s._next,t++}),this.length=t;return this._truncate(s),this.collection=e,this.isDirty}get isDirty(){return null!==this._additionsHead||null!==this._movesHead||null!==this._removalsHead||null!==this._identityChangesHead}_reset(){if(this.isDirty){let e;for(e=this._previousItHead=this._itHead;null!==e;e=e._next)e._nextPrevious=e._next;for(e=this._additionsHead;null!==e;e=e._nextAdded)e.previousIndex=e.currentIndex;for(this._additionsHead=this._additionsTail=null,e=this._movesHead;null!==e;e=e._nextMoved)e.previousIndex=e.currentIndex;this._movesHead=this._movesTail=null,this._removalsHead=this._removalsTail=null,this._identityChangesHead=this._identityChangesTail=null}}_mismatch(e,t,n,r){let s;return null===e?s=this._itTail:(s=e._prev,this._remove(e)),null!==(e=null===this._unlinkedRecords?null:this._unlinkedRecords.get(n,null))?(Object.is(e.item,t)||this._addIdentityChange(e,t),this._reinsertAfter(e,s,r)):null!==(e=null===this._linkedRecords?null:this._linkedRecords.get(n,r))?(Object.is(e.item,t)||this._addIdentityChange(e,t),this._moveAfter(e,s,r)):e=this._addAfter(new ks(t,n),s,r),e}_verifyReinsertion(e,t,n,r){let s=null===this._unlinkedRecords?null:this._unlinkedRecords.get(n,null);return null!==s?e=this._reinsertAfter(s,e._prev,r):e.currentIndex!=r&&(e.currentIndex=r,this._addToMoves(e,r)),e}_truncate(e){for(;null!==e;){const t=e._next;this._addToRemovals(this._unlink(e)),e=t}null!==this._unlinkedRecords&&this._unlinkedRecords.clear(),null!==this._additionsTail&&(this._additionsTail._nextAdded=null),null!==this._movesTail&&(this._movesTail._nextMoved=null),null!==this._itTail&&(this._itTail._next=null),null!==this._removalsTail&&(this._removalsTail._nextRemoved=null),null!==this._identityChangesTail&&(this._identityChangesTail._nextIdentityChange=null)}_reinsertAfter(e,t,n){null!==this._unlinkedRecords&&this._unlinkedRecords.remove(e);const r=e._prevRemoved,s=e._nextRemoved;return null===r?this._removalsHead=s:r._nextRemoved=s,null===s?this._removalsTail=r:s._prevRemoved=r,this._insertAfter(e,t,n),this._addToMoves(e,n),e}_moveAfter(e,t,n){return this._unlink(e),this._insertAfter(e,t,n),this._addToMoves(e,n),e}_addAfter(e,t,n){return this._insertAfter(e,t,n),this._additionsTail=null===this._additionsTail?this._additionsHead=e:this._additionsTail._nextAdded=e,e}_insertAfter(e,t,n){const r=null===t?this._itHead:t._next;return e._next=r,e._prev=t,null===r?this._itTail=e:r._prev=e,null===t?this._itHead=e:t._next=e,null===this._linkedRecords&&(this._linkedRecords=new Ss),this._linkedRecords.put(e),e.currentIndex=n,e}_remove(e){return this._addToRemovals(this._unlink(e))}_unlink(e){null!==this._linkedRecords&&this._linkedRecords.remove(e);const t=e._prev,n=e._next;return null===t?this._itHead=n:t._next=n,null===n?this._itTail=t:n._prev=t,e}_addToMoves(e,t){return e.previousIndex===t||(this._movesTail=null===this._movesTail?this._movesHead=e:this._movesTail._nextMoved=e),e}_addToRemovals(e){return null===this._unlinkedRecords&&(this._unlinkedRecords=new Ss),this._unlinkedRecords.put(e),e.currentIndex=null,e._nextRemoved=null,null===this._removalsTail?(this._removalsTail=this._removalsHead=e,e._prevRemoved=null):(e._prevRemoved=this._removalsTail,this._removalsTail=this._removalsTail._nextRemoved=e),e}_addIdentityChange(e,t){return e.item=t,this._identityChangesTail=null===this._identityChangesTail?this._identityChangesHead=e:this._identityChangesTail._nextIdentityChange=e,e}}class ks{constructor(e,t){this.item=e,this.trackById=t,this.currentIndex=null,this.previousIndex=null,this._nextPrevious=null,this._prev=null,this._next=null,this._prevDup=null,this._nextDup=null,this._prevRemoved=null,this._nextRemoved=null,this._nextAdded=null,this._nextMoved=null,this._nextIdentityChange=null}}class Ts{constructor(){this._head=null,this._tail=null}add(e){null===this._head?(this._head=this._tail=e,e._nextDup=null,e._prevDup=null):(this._tail._nextDup=e,e._prevDup=this._tail,e._nextDup=null,this._tail=e)}get(e,t){let n;for(n=this._head;null!==n;n=n._nextDup)if((null===t||t<=n.currentIndex)&&Object.is(n.trackById,e))return n;return null}remove(e){const t=e._prevDup,n=e._nextDup;return null===t?this._head=n:t._nextDup=n,null===n?this._tail=t:n._prevDup=t,null===this._head}}class Ss{constructor(){this.map=new Map}put(e){const t=e.trackById;let n=this.map.get(t);n||(n=new Ts,this.map.set(t,n)),n.add(e)}get(e,t){const n=this.map.get(e);return n?n.get(e,t):null}remove(e){const t=e.trackById;return this.map.get(t).remove(e)&&this.map.delete(t),e}get isEmpty(){return 0===this.map.size}clear(){this.map.clear()}}function Is(e,t,n){const r=e.previousIndex;if(null===r)return r;let s=0;return n&&r<n.length&&(s=n[r]),r+t+s}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */class As{constructor(){}supports(e){return e instanceof Map||Yr(e)}create(){return new Ds}}class Ds{constructor(){this._records=new Map,this._mapHead=null,this._appendAfter=null,this._previousMapHead=null,this._changesHead=null,this._changesTail=null,this._additionsHead=null,this._additionsTail=null,this._removalsHead=null,this._removalsTail=null}get isDirty(){return null!==this._additionsHead||null!==this._changesHead||null!==this._removalsHead}forEachItem(e){let t;for(t=this._mapHead;null!==t;t=t._next)e(t)}forEachPreviousItem(e){let t;for(t=this._previousMapHead;null!==t;t=t._nextPrevious)e(t)}forEachChangedItem(e){let t;for(t=this._changesHead;null!==t;t=t._nextChanged)e(t)}forEachAddedItem(e){let t;for(t=this._additionsHead;null!==t;t=t._nextAdded)e(t)}forEachRemovedItem(e){let t;for(t=this._removalsHead;null!==t;t=t._nextRemoved)e(t)}diff(e){if(e){if(!(e instanceof Map||Yr(e)))throw new Error(`Error trying to diff '${G(e)}'. Only maps and objects are allowed`)}else e=new Map;return this.check(e)?this:null}onDestroy(){}check(e){this._reset();let t=this._mapHead;if(this._appendAfter=null,this._forEach(e,(e,n)=>{if(t&&t.key===n)this._maybeAddToChanges(t,e),this._appendAfter=t,t=t._next;else{const r=this._getOrCreateRecordForKey(n,e);t=this._insertBeforeOrAppend(t,r)}}),t){t._prev&&(t._prev._next=null),this._removalsHead=t;for(let e=t;null!==e;e=e._nextRemoved)e===this._mapHead&&(this._mapHead=null),this._records.delete(e.key),e._nextRemoved=e._next,e.previousValue=e.currentValue,e.currentValue=null,e._prev=null,e._next=null}return this._changesTail&&(this._changesTail._nextChanged=null),this._additionsTail&&(this._additionsTail._nextAdded=null),this.isDirty}_insertBeforeOrAppend(e,t){if(e){const n=e._prev;return t._next=e,t._prev=n,e._prev=t,n&&(n._next=t),e===this._mapHead&&(this._mapHead=t),this._appendAfter=e,e}return this._appendAfter?(this._appendAfter._next=t,t._prev=this._appendAfter):this._mapHead=t,this._appendAfter=t,null}_getOrCreateRecordForKey(e,t){if(this._records.has(e)){const n=this._records.get(e);this._maybeAddToChanges(n,t);const r=n._prev,s=n._next;return r&&(r._next=s),s&&(s._prev=r),n._next=null,n._prev=null,n}const n=new Os(e);return this._records.set(e,n),n.currentValue=t,this._addToAdditions(n),n}_reset(){if(this.isDirty){let e;for(this._previousMapHead=this._mapHead,e=this._previousMapHead;null!==e;e=e._next)e._nextPrevious=e._next;for(e=this._changesHead;null!==e;e=e._nextChanged)e.previousValue=e.currentValue;for(e=this._additionsHead;null!=e;e=e._nextAdded)e.previousValue=e.currentValue;this._changesHead=this._changesTail=null,this._additionsHead=this._additionsTail=null,this._removalsHead=null}}_maybeAddToChanges(e,t){Object.is(t,e.currentValue)||(e.previousValue=e.currentValue,e.currentValue=t,this._addToChanges(e))}_addToAdditions(e){null===this._additionsHead?this._additionsHead=this._additionsTail=e:(this._additionsTail._nextAdded=e,this._additionsTail=e)}_addToChanges(e){null===this._changesHead?this._changesHead=this._changesTail=e:(this._changesTail._nextChanged=e,this._changesTail=e)}_forEach(e,t){e instanceof Map?e.forEach(t):Object.keys(e).forEach(n=>t(e[n],n))}}class Os{constructor(e){this.key=e,this.previousValue=null,this.currentValue=null,this._nextPrevious=null,this._next=null,this._prev=null,this._nextAdded=null,this._nextRemoved=null,this._nextChanged=null
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */}}function js(){return new Hs([new Cs])}let Hs=(()=>{class e{constructor(e){this.factories=e}static create(t,n){if(null!=n){const e=n.factories.slice();t=t.concat(e)}return new e(t)}static extend(t){return{provide:e,useFactory:n=>e.create(t,n||js()),deps:[[e,new gn,new mn]]}}find(e){const t=this.factories.find(t=>t.supports(e));if(null!=t)return t;throw new Error(`Cannot find a differ supporting object '${e}' of type '${n=e,n.name||typeof n}'`);var n;
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */}}return e.\u0275prov=te({token:e,providedIn:"root",factory:js}),e})();function Ps(){return new Rs([new As])}let Rs=(()=>{class e{constructor(e){this.factories=e}static create(t,n){if(n){const e=n.factories.slice();t=t.concat(e)}return new e(t)}static extend(t){return{provide:e,useFactory:n=>e.create(t,n||Ps()),deps:[[e,new gn,new mn]]}}find(e){const t=this.factories.find(t=>t.supports(e));if(t)return t;throw new Error(`Cannot find a differ supporting object '${e}'`)}}return e.\u0275prov=te({token:e,providedIn:"root",factory:Ps}),e})();
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */function Ns(e,t,n,r,s=!1){for(;null!==n;){const o=t[n.index];if(null!==o&&r.push(Ke(o)),Le(o))for(let e=10;e<o.length;e++){const t=o[e],n=t[1].firstChild;null!==n&&Ns(t[1],t,n,r)}const i=n.type;if(8&i)Ns(e,t,n.child,r);else if(32&i){const e=Sn(n,t);let s;for(;s=e();)r.push(s)}else if(16&i){const e=Ln(t,n);if(Array.isArray(e))r.push(...e);else{const n=In(t[16]);Ns(n[1],n,e,r,!0)}}n=s?n.projectionNext:n.next}return r}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */class Ms extends class{constructor(e,t){this._lView=e,this._cdRefInjectingView=t,this._appRef=null,this._attachedToViewContainer=!1}get rootNodes(){const e=this._lView,t=e[1];return Ns(t,e,t.firstChild,[])}get context(){return this._lView[8]}get destroyed(){return 256==(256&this._lView[2])}destroy(){if(this._appRef)this._appRef.detachView(this);else if(this._attachedToViewContainer){const e=this._lView[3];if(Le(e)){const t=e[8],n=t?t.indexOf(this):-1;n>-1&&(function(e,t){if(e.length<=10)return;const n=10+t,r=e[n];if(r){const o=r[17];null!==o&&o!==e&&Pn(o,r),t>0&&(e[n-1][4]=r[4]);const i=on(e,10+t);Bn(r[1],s=r,s[11],2,null,null),s[0]=null,s[6]=null;const l=i[19];null!==l&&l.detachView(i[1]),r[3]=null,r[4]=null,r[2]&=-129}var s}(e,n),on(t,n))}this._attachedToViewContainer=!1}!function(e,t){if(!(256&t[2])){const n=t[11];Qe(n)&&n.destroyNode&&Bn(e,t,n,3,null,null),function(e){let t=e[13];if(!t)return Rn(e[1],e);for(;t;){let n=null;if(Ve(t))n=t[13];else{const e=t[10];e&&(n=e)}if(!n){for(;t&&!t[4]&&t!==e;)Ve(t)&&Rn(t[1],t),t=t[3];null===t&&(t=e),Ve(t)&&Rn(t[1],t),n=t&&t[4]}t=n}}(t)}}(this._lView[1],this._lView)}onDestroy(e){!function(e,t,n,r){const s=(o=t)[7]||(o[7]=[]);var o;s.push(r)}(0,this._lView,0,e)}markForCheck(){!function(e){for(;e;){e[2]|=64;const t=In(e);if(0!=(512&e[2])&&!t)return e;e=t}}(this._cdRefInjectingView||this._lView)}detach(){this._lView[2]&=-129}reattach(){this._lView[2]|=128}detectChanges(){Sr(this._lView[1],this._lView,this.context)}checkNoChanges(){!function(e,t,n){pt(!0);try{Sr(e,t,n)}finally{pt(!1)}}(this._lView[1],this._lView,this.context)}attachToViewContainerRef(){if(this._appRef)throw new Error("This view is already attached directly to the ApplicationRef!");this._attachedToViewContainer=!0}detachFromAppRef(){var e;this._appRef=null,Bn(this._lView[1],e=this._lView,e[11],2,null,null)}attachToAppRef(e){if(this._attachedToViewContainer)throw new Error("This view is already attached to a ViewContainer!");this._appRef=e}}{constructor(e){super(e),this._view=e}detectChanges(){Ir(this._view)}checkNoChanges(){!function(e){pt(!0);try{Ir(e)}finally{pt(!1)}}(this._view)}get context(){return null}}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */const Fs=[new As],Vs=new Hs([new Cs]),Ls=new Rs(Fs);
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */class Zs{}const Bs={};
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */class $s extends fs{constructor(e){super(),this.ngModule=e}resolveComponentFactory(e){const t=Me(e);return new Ws(t,this.ngModule)}}function zs(e){const t=[];for(let n in e)e.hasOwnProperty(n)&&t.push({propName:e[n],templateName:n});return t}const Us=new rn("SCHEDULER_TOKEN",{providedIn:"root",factory:()=>xn});class Ws extends hs{constructor(e,t){super(),this.componentDef=e,this.ngModule=t,this.componentType=e.type,this.selector=e.selectors.map(tr).join(","),this.ngContentSelectors=e.ngContentSelectors?e.ngContentSelectors:[],this.isBoundToModule=!!t}get inputs(){return zs(this.componentDef.inputs)}get outputs(){return zs(this.componentDef.outputs)}create(e,t,n,r){const s=(r=r||this.ngModule)?function(e,t){return{get:(n,r,s)=>{const o=e.get(n,Bs,s);return o!==Bs||r===Bs?o:t.get(n,r,s)}}}(e,r.injector):e,o=s.get(gs,Je),i=s.get(vs,null),l=o.createRenderer(null,this.componentDef),u=this.componentDef.selectors[0][0]||"div",c=n?function(e,t,n){if(Qe(e))return e.selectRootElement(t,n===ye.ShadowDom);let r="string"==typeof t?e.querySelector(t):t;return r.textContent="",r}(l,n,this.componentDef.encapsulation):Hn(o.createRenderer(null,this.componentDef),u,function(e){const t=e.toLowerCase();return"svg"===t?"http://www.w3.org/2000/svg":"math"===t?"http://www.w3.org/1998/MathML/":null}(u)),a=this.componentDef.onPush?576:528,h={components:[],scheduler:xn,clean:Dr,playerHandler:null,flags:0},d=dr(0,null,null,1,0,null,null,null,null,null),f=sr(null,d,h,a,null,null,o,l,i,s);let p,_;bt(f);try{const e=function(e,t,n,r,s,o){const i=n[1];n[20]=e;const l=or(i,20,2,"#host",null),u=l.mergedAttrs=t.hostAttrs;null!==u&&(Or(l,u,!0),null!==e&&(Pt(s,e,u),null!==l.classes&&Un(s,e,l.classes),null!==l.styles&&zn(s,e,l.styles)));const c=r.createRenderer(e,t),a=sr(n,hr(t),null,t.onPush?64:16,n[20],l,r,c,null,null);return i.firstCreatePass&&(Wt(Bt(l,n),i,t.type),yr(i,l),gr(l,n.length,1)),Tr(n,a),n[20]=a}(c,this.componentDef,f,o,l);if(c)if(n)Pt(l,c,["ng-version",ws.full]);else{const{attrs:e,classes:t}=function(e){const t=[],n=[];let r=1,s=2;for(;r<e.length;){let o=e[r];if("string"==typeof o)2===s?""!==o&&t.push(o,e[++r]):8===s&&n.push(o);else{if(!Kn(s))break;s=o}r++}return{attrs:t,classes:n}}(this.componentDef.selectors[0]);e&&Pt(l,c,e),t&&t.length>0&&Un(l,c,t.join(" "))}if(_=d.data[20],void 0!==t){const e=_.projection=[];for(let n=0;n<this.ngContentSelectors.length;n++){const r=t[n];e.push(null!=r?Array.from(r):null)}}p=function(e,t,n,r,s){const o=n[1],i=function(e,t,n){const r=ct();e.firstCreatePass&&(n.providersResolver&&n.providersResolver(n),vr(e,r,t,ir(e,t,1,null),n));const s=Yt(t,e,r.directiveStart,r);En(s,t);const o=Ye(r,t);return o&&En(o,t),s}(o,n,t);if(r.components.push(i),e[8]=i,s&&s.forEach(e=>e(i,t)),t.contentQueries){const e=ct();t.contentQueries(1,i,e.directiveStart)}const l=ct();return!o.firstCreatePass||null===t.hostBindings&&null===t.hostAttrs||(Tt(l.index),pr(n[1],l,0,l.directiveStart,l.directiveEnd,t),_r(t,i)),i}(e,this.componentDef,f,h,[qr]),lr(d,f,null)}finally{kt()}return new Gs(this.componentType,p,_s(_,f),f,_)}}class Gs extends
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */
class{}{constructor(e,t,n,r,s){super(),this.location=n,this._rootLView=r,this._tNode=s,this.instance=t,this.hostView=this.changeDetectorRef=new Ms(r),this.componentType=e}get injector(){return new tn(this._tNode,this._rootLView)}destroy(){this.hostView.destroy()}onDestroy(e){this.hostView.onDestroy(e)}}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */const qs=new Map;
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */class Qs extends Zs{constructor(e,t){super(),this._parent=t,this._bootstrapComponents=[],this.injector=this,this.destroyCbs=[],this.componentFactoryResolver=new $s(this);const n=Fe(e),r=e[Ie]||null;r&&as(r),this._bootstrapComponents=kn(n.bootstrap),this._r3Injector=Lr(e,t,[{provide:Zs,useValue:this},{provide:fs,useValue:this.componentFactoryResolver}],G(e)),this._r3Injector._resolveInjectorDefTypes(),this.instance=this.get(e)}get(e,t=Gr.THROW_IF_NOT_FOUND,n=ae.Default){return e===Gr||e===Zs||e===jr?this:this._r3Injector.get(e,t,n)}destroy(){const e=this._r3Injector;!e.destroyed&&e.destroy(),this.destroyCbs.forEach(e=>e()),this.destroyCbs=null}onDestroy(e){this.destroyCbs.push(e)}}class Js extends class{}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */{constructor(e){super(),this.moduleType=e,null!==Fe(e)&&function(e){const t=new Set;!function e(n){const r=Fe(n,!0),s=r.id;null!==s&&(function(e,t,n){if(t&&t!==n)throw new Error(`Duplicate module registered for ${e} - ${G(t)} vs ${G(t.name)}`)}(s,qs.get(s),n),qs.set(s,n));const o=kn(r.imports);for(const i of o)t.has(i)||(t.add(i),e(i))}(e)}(e)}create(e){return new Qs(this.moduleType,e)}}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */function Ks(e){return t=>{setTimeout(e,void 0,t)}}const Ys=
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */
class extends E{constructor(e=!1){super(),this.__isAsync=e}emit(e){super.next(e)}subscribe(e,t,n){var r,s,o;let i=e,l=t||(()=>null),u=n;if(e&&"object"==typeof e){const t=e;i=null===(r=t.next)||void 0===r?void 0:r.bind(t),l=null===(s=t.error)||void 0===s?void 0:s.bind(t),u=null===(o=t.complete)||void 0===o?void 0:o.bind(t)}this.__isAsync&&(l=Ks(l),i&&(i=Ks(i)),u&&(u=Ks(u)));const c=super.subscribe({next:i,error:l,complete:u});return e instanceof h&&e.add(c),c}},Xs=new rn("Application Initializer");
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */let eo=(()=>{class e{constructor(e){this.appInits=e,this.resolve=ps,this.reject=ps,this.initialized=!1,this.done=!1,this.donePromise=new Promise((e,t)=>{this.resolve=e,this.reject=t})}runInitializers(){if(this.initialized)return;const e=[],t=()=>{this.done=!0,this.resolve()};if(this.appInits)for(let n=0;n<this.appInits.length;n++){const t=this.appInits[n]();ns(t)&&e.push(t)}Promise.all(e).then(()=>{t()}).catch(e=>{this.reject(e)}),0===e.length&&t(),this.initialized=!0}}return e.\u0275fac=function(t){return new(t||e)(fn(Xs,8))},e.\u0275prov=te({token:e,factory:e.\u0275fac}),e})();
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */const to=new rn("AppId"),no={provide:to,useFactory:function(){return`${ro()}${ro()}${ro()}`},deps:[]};function ro(){return String.fromCharCode(97+Math.floor(25*Math.random()))}const so=new rn("Platform Initializer"),oo=new rn("Platform ID"),io=new rn("appBootstrapListener");let lo=(()=>{class e{log(e){console.log(e)}warn(e){console.warn(e)}}return e.\u0275fac=function(t){return new(t||e)},e.\u0275prov=te({token:e,factory:e.\u0275fac}),e})();
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */const uo=new rn("LocaleId"),co=new rn("DefaultCurrencyCode");
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */class ao{constructor(e,t){this.ngModuleFactory=e,this.componentFactories=t}}const ho=function(e){return new Js(e)},fo=ho,po=function(e){return Promise.resolve(ho(e))},_o=function(e){const t=ho(e),n=kn(Fe(e).declarations).reduce((e,t)=>{const n=Me(t);return n&&e.push(new Ws(n)),e},[]);return new ao(t,n)},yo=_o,mo=function(e){return Promise.resolve(_o(e))};let go=(()=>{class e{constructor(){this.compileModuleSync=fo,this.compileModuleAsync=po,this.compileModuleAndAllComponentsSync=yo,this.compileModuleAndAllComponentsAsync=mo}clearCache(){}clearCacheFor(e){}getModuleId(e){}}return e.\u0275fac=function(t){return new(t||e)},e.\u0275prov=te({token:e,factory:e.\u0275fac}),e})();const vo=(()=>Promise.resolve(0))();function bo(e){"undefined"==typeof Zone?vo.then(()=>{e&&e.apply(null,null)}):Zone.current.scheduleMicroTask("scheduleMicrotask",e)}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */class wo{constructor({enableLongStackTrace:e=!1,shouldCoalesceEventChangeDetection:t=!1,shouldCoalesceRunChangeDetection:n=!1}){if(this.hasPendingMacrotasks=!1,this.hasPendingMicrotasks=!1,this.isStable=!0,this.onUnstable=new Ys(!1),this.onMicrotaskEmpty=new Ys(!1),this.onStable=new Ys(!1),this.onError=new Ys(!1),"undefined"==typeof Zone)throw new Error("In this configuration Angular requires Zone.js");Zone.assertZonePatched(),this._nesting=0,this._outer=this._inner=Zone.current,Zone.TaskTrackingZoneSpec&&(this._inner=this._inner.fork(new Zone.TaskTrackingZoneSpec)),e&&Zone.longStackTraceZoneSpec&&(this._inner=this._inner.fork(Zone.longStackTraceZoneSpec)),this.shouldCoalesceEventChangeDetection=!n&&t,this.shouldCoalesceRunChangeDetection=n,this.lastRequestAnimationFrameId=-1,this.nativeRequestAnimationFrame=function(){let e=we.requestAnimationFrame,t=we.cancelAnimationFrame;if("undefined"!=typeof Zone&&e&&t){const n=e[Zone.__symbol__("OriginalDelegate")];n&&(e=n);const r=t[Zone.__symbol__("OriginalDelegate")];r&&(t=r)}return{nativeRequestAnimationFrame:e,nativeCancelAnimationFrame:t}}().nativeRequestAnimationFrame,function(e){const t=()=>{!function(e){-1===e.lastRequestAnimationFrameId&&(e.lastRequestAnimationFrameId=e.nativeRequestAnimationFrame.call(we,()=>{e.fakeTopEventTask||(e.fakeTopEventTask=Zone.root.scheduleEventTask("fakeTopEventTask",()=>{e.lastRequestAnimationFrameId=-1,xo(e),Eo(e)},void 0,()=>{},()=>{})),e.fakeTopEventTask.invoke()}),xo(e))}(e)};e._inner=e._inner.fork({name:"angular",properties:{isAngularZone:!0},onInvokeTask:(n,r,s,o,i,l)=>{try{return ko(e),n.invokeTask(s,o,i,l)}finally{(e.shouldCoalesceEventChangeDetection&&"eventTask"===o.type||e.shouldCoalesceRunChangeDetection)&&t(),To(e)}},onInvoke:(n,r,s,o,i,l,u)=>{try{return ko(e),n.invoke(s,o,i,l,u)}finally{e.shouldCoalesceRunChangeDetection&&t(),To(e)}},onHasTask:(t,n,r,s)=>{t.hasTask(r,s),n===r&&("microTask"==s.change?(e._hasPendingMicrotasks=s.microTask,xo(e),Eo(e)):"macroTask"==s.change&&(e.hasPendingMacrotasks=s.macroTask))},onHandleError:(t,n,r,s)=>(t.handleError(r,s),e.runOutsideAngular(()=>e.onError.emit(s)),!1)})}(this)}static isInAngularZone(){return!0===Zone.current.get("isAngularZone")}static assertInAngularZone(){if(!wo.isInAngularZone())throw new Error("Expected to be in Angular Zone, but it is not!")}static assertNotInAngularZone(){if(wo.isInAngularZone())throw new Error("Expected to not be in Angular Zone, but it is!")}run(e,t,n){return this._inner.run(e,t,n)}runTask(e,t,n,r){const s=this._inner,o=s.scheduleEventTask("NgZoneEvent: "+r,e,Co,ps,ps);try{return s.runTask(o,t,n)}finally{s.cancelTask(o)}}runGuarded(e,t,n){return this._inner.runGuarded(e,t,n)}runOutsideAngular(e){return this._outer.run(e)}}const Co={};function Eo(e){if(0==e._nesting&&!e.hasPendingMicrotasks&&!e.isStable)try{e._nesting++,e.onMicrotaskEmpty.emit(null)}finally{if(e._nesting--,!e.hasPendingMicrotasks)try{e.runOutsideAngular(()=>e.onStable.emit(null))}finally{e.isStable=!0}}}function xo(e){e.hasPendingMicrotasks=!!(e._hasPendingMicrotasks||(e.shouldCoalesceEventChangeDetection||e.shouldCoalesceRunChangeDetection)&&-1!==e.lastRequestAnimationFrameId)}function ko(e){e._nesting++,e.isStable&&(e.isStable=!1,e.onUnstable.emit(null))}function To(e){e._nesting--,Eo(e)}class So{constructor(){this.hasPendingMicrotasks=!1,this.hasPendingMacrotasks=!1,this.isStable=!0,this.onUnstable=new Ys,this.onMicrotaskEmpty=new Ys,this.onStable=new Ys,this.onError=new Ys}run(e,t,n){return e.apply(t,n)}runGuarded(e,t,n){return e.apply(t,n)}runOutsideAngular(e){return e()}runTask(e,t,n,r){return e.apply(t,n)}}let Io=(()=>{class e{constructor(e){this._ngZone=e,this._pendingCount=0,this._isZoneStable=!0,this._didWork=!1,this._callbacks=[],this.taskTrackingZone=null,this._watchAngularEvents(),e.run(()=>{this.taskTrackingZone="undefined"==typeof Zone?null:Zone.current.get("TaskTrackingZone")})}_watchAngularEvents(){this._ngZone.onUnstable.subscribe({next:()=>{this._didWork=!0,this._isZoneStable=!1}}),this._ngZone.runOutsideAngular(()=>{this._ngZone.onStable.subscribe({next:()=>{wo.assertNotInAngularZone(),bo(()=>{this._isZoneStable=!0,this._runCallbacksIfReady()})}})})}increasePendingRequestCount(){return this._pendingCount+=1,this._didWork=!0,this._pendingCount}decreasePendingRequestCount(){if(this._pendingCount-=1,this._pendingCount<0)throw new Error("pending async requests below zero");return this._runCallbacksIfReady(),this._pendingCount}isStable(){return this._isZoneStable&&0===this._pendingCount&&!this._ngZone.hasPendingMacrotasks}_runCallbacksIfReady(){if(this.isStable())bo(()=>{for(;0!==this._callbacks.length;){let e=this._callbacks.pop();clearTimeout(e.timeoutId),e.doneCb(this._didWork)}this._didWork=!1});else{let e=this.getPendingTasks();this._callbacks=this._callbacks.filter(t=>!t.updateCb||!t.updateCb(e)||(clearTimeout(t.timeoutId),!1)),this._didWork=!0}}getPendingTasks(){return this.taskTrackingZone?this.taskTrackingZone.macroTasks.map(e=>({source:e.source,creationLocation:e.creationLocation,data:e.data})):[]}addCallback(e,t,n){let r=-1;t&&t>0&&(r=setTimeout(()=>{this._callbacks=this._callbacks.filter(e=>e.timeoutId!==r),e(this._didWork,this.getPendingTasks())},t)),this._callbacks.push({doneCb:e,timeoutId:r,updateCb:n})}whenStable(e,t,n){if(n&&!this.taskTrackingZone)throw new Error('Task tracking zone is required when passing an update callback to whenStable(). Is "zone.js/dist/task-tracking.js" loaded?');this.addCallback(e,t,n),this._runCallbacksIfReady()}getPendingRequestCount(){return this._pendingCount}findProviders(e,t,n){return[]}}return e.\u0275fac=function(t){return new(t||e)(fn(wo))},e.\u0275prov=te({token:e,factory:e.\u0275fac}),e})(),Ao=(()=>{class e{constructor(){this._applications=new Map,jo.addToWindow(this)}registerApplication(e,t){this._applications.set(e,t)}unregisterApplication(e){this._applications.delete(e)}unregisterAllApplications(){this._applications.clear()}getTestability(e){return this._applications.get(e)||null}getAllTestabilities(){return Array.from(this._applications.values())}getAllRootElements(){return Array.from(this._applications.keys())}findTestabilityInTree(e,t=!0){return jo.findTestabilityInTree(this,e,t)}}return e.\u0275fac=function(t){return new(t||e)},e.\u0275prov=te({token:e,factory:e.\u0275fac}),e})();class Do{addToWindow(e){}findTestabilityInTree(e,t,n){return null}}let Oo,jo=new Do,Ho=!0,Po=!1;
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */const Ro=new rn("AllowMultipleToken");function No(e,t,n=[]){const r=`Platform: ${t}`,s=new rn(r);return(t=[])=>{let o=Mo();if(!o||o.injector.get(Ro,!1))if(e)e(n.concat(t).concat({provide:s,useValue:!0}));else{const e=n.concat(t).concat({provide:s,useValue:!0},{provide:Pr,useValue:"platform"});!function(e){if(Oo&&!Oo.destroyed&&!Oo.injector.get(Ro,!1))throw new Error("There can be only one platform. Destroy the previous one to create a new one.");Oo=e.get(Fo);const t=e.get(so,null);t&&t.forEach(e=>e())}(Gr.create({providers:e,name:r}))}return function(e){const t=Mo();if(!t)throw new Error("No platform exists!");if(!t.injector.get(e,null))throw new Error("A platform with a different configuration has been created. Please destroy it first.");return t}(s)}}function Mo(){return Oo&&!Oo.destroyed?Oo:null}let Fo=(()=>{class e{constructor(e){this._injector=e,this._modules=[],this._destroyListeners=[],this._destroyed=!1}bootstrapModuleFactory(e,t){const n=function(e,t){let n;return n="noop"===e?new So:("zone.js"===e?void 0:e)||new wo({enableLongStackTrace:(Po=!0,Ho),shouldCoalesceEventChangeDetection:!!(null==t?void 0:t.ngZoneEventCoalescing),shouldCoalesceRunChangeDetection:!!(null==t?void 0:t.ngZoneRunCoalescing)}),n}(t?t.ngZone:void 0,{ngZoneEventCoalescing:t&&t.ngZoneEventCoalescing||!1,ngZoneRunCoalescing:t&&t.ngZoneRunCoalescing||!1}),r=[{provide:wo,useValue:n}];return n.run(()=>{const t=Gr.create({providers:r,parent:this.injector,name:e.moduleType.name}),s=e.create(t),o=s.injector.get(Cn,null);if(!o)throw new Error("No ErrorHandler. Is platform module (BrowserModule) included?");return n.runOutsideAngular(()=>{const e=n.onError.subscribe({next:e=>{o.handleError(e)}});s.onDestroy(()=>{Zo(this._modules,s),e.unsubscribe()})}),function(e,t,n){try{const r=n();return ns(r)?r.catch(n=>{throw t.runOutsideAngular(()=>e.handleError(n)),n}):r}catch(r){throw t.runOutsideAngular(()=>e.handleError(r)),r}}(o,n,()=>{const e=s.injector.get(eo);return e.runInitializers(),e.donePromise.then(()=>(as(s.injector.get(uo,"en-US")||"en-US"),this._moduleDoBootstrap(s),s))})})}bootstrapModule(e,t=[]){const n=Vo({},t);return function(e,t,n){const r=new Js(n);return Promise.resolve(r)}(0,0,e).then(e=>this.bootstrapModuleFactory(e,n))}_moduleDoBootstrap(e){const t=e.injector.get(Lo);if(e._bootstrapComponents.length>0)e._bootstrapComponents.forEach(e=>t.bootstrap(e));else{if(!e.instance.ngDoBootstrap)throw new Error(`The module ${G(e.instance.constructor)} was bootstrapped, but it does not declare "@NgModule.bootstrap" components nor a "ngDoBootstrap" method. Please define one of these.`);e.instance.ngDoBootstrap(t)}this._modules.push(e)}onDestroy(e){this._destroyListeners.push(e)}get injector(){return this._injector}destroy(){if(this._destroyed)throw new Error("The platform has already been destroyed!");this._modules.slice().forEach(e=>e.destroy()),this._destroyListeners.forEach(e=>e()),this._destroyed=!0}get destroyed(){return this._destroyed}}return e.\u0275fac=function(t){return new(t||e)(fn(Gr))},e.\u0275prov=te({token:e,factory:e.\u0275fac}),e})();function Vo(e,t){return Array.isArray(t)?t.reduce(Vo,e):Object.assign(Object.assign({},e),t)}let Lo=(()=>{class e{constructor(e,t,n,r,s){this._zone=e,this._injector=t,this._exceptionHandler=n,this._componentFactoryResolver=r,this._initStatus=s,this._bootstrapListeners=[],this._views=[],this._runningTick=!1,this._stable=!0,this.componentTypes=[],this.components=[],this._onMicrotaskEmptySubscription=this._zone.onMicrotaskEmpty.subscribe({next:()=>{this._zone.run(()=>{this.tick()})}});const o=new g(e=>{this._stable=this._zone.isStable&&!this._zone.hasPendingMacrotasks&&!this._zone.hasPendingMicrotasks,this._zone.runOutsideAngular(()=>{e.next(this._stable),e.complete()})}),i=new g(e=>{let t;this._zone.runOutsideAngular(()=>{t=this._zone.onStable.subscribe(()=>{wo.assertNotInAngularZone(),bo(()=>{this._stable||this._zone.hasPendingMacrotasks||this._zone.hasPendingMicrotasks||(this._stable=!0,e.next(!0))})})});const n=this._zone.onUnstable.subscribe(()=>{wo.assertInAngularZone(),this._stable&&(this._stable=!1,this._zone.runOutsideAngular(()=>{e.next(!1)}))});return()=>{t.unsubscribe(),n.unsubscribe()}});this.isStable=function(...e){let t=Number.POSITIVE_INFINITY,n=null,r=e[e.length-1];var s;return(s=r)&&"function"==typeof s.schedule?(n=e.pop(),e.length>1&&"number"==typeof e[e.length-1]&&(t=e.pop())):"number"==typeof r&&(t=e.pop()),null===n&&1===e.length&&e[0]instanceof g?e[0]:function(e=Number.POSITIVE_INFINITY){return N(m,e)}(t)(function(e,t){return t?H(e,t):new g(S(e))}(e,n))}(o,i.pipe(e=>{return V()((t=U,function(e){let n;n="function"==typeof t?t:function(){return t};const r=Object.create(e,$);return r.source=e,r.subjectFactory=n,r})(e));var t}))}bootstrap(e,t){if(!this._initStatus.done)throw new Error("Cannot bootstrap as there are still asynchronous initializers running. Bootstrap components in the `ngDoBootstrap` method of the root module.");let n;n=e instanceof hs?e:this._componentFactoryResolver.resolveComponentFactory(e),this.componentTypes.push(n.componentType);const r=n.isBoundToModule?void 0:this._injector.get(Zs),s=n.create(Gr.NULL,[],t||n.selector,r),o=s.location.nativeElement,i=s.injector.get(Io,null),l=i&&s.injector.get(Ao);return i&&l&&l.registerApplication(o,i),s.onDestroy(()=>{this.detachView(s.hostView),Zo(this.components,s),l&&l.unregisterApplication(o)}),this._loadComponent(s),s}tick(){if(this._runningTick)throw new Error("ApplicationRef.tick is called recursively");try{this._runningTick=!0;for(let e of this._views)e.detectChanges()}catch(e){this._zone.runOutsideAngular(()=>this._exceptionHandler.handleError(e))}finally{this._runningTick=!1}}attachView(e){const t=e;this._views.push(t),t.attachToAppRef(this)}detachView(e){const t=e;Zo(this._views,t),t.detachFromAppRef()}_loadComponent(e){this.attachView(e.hostView),this.tick(),this.components.push(e),this._injector.get(io,[]).concat(this._bootstrapListeners).forEach(t=>t(e))}ngOnDestroy(){this._views.slice().forEach(e=>e.destroy()),this._onMicrotaskEmptySubscription.unsubscribe()}get viewCount(){return this._views.length}}return e.\u0275fac=function(t){return new(t||e)(fn(wo),fn(Gr),fn(Cn),fn(fs),fn(eo))},e.\u0275prov=te({token:e,factory:e.\u0275fac}),e})();function Zo(e,t){const n=e.indexOf(t);n>-1&&e.splice(n,1)}const Bo=No(null,"core",[{provide:oo,useValue:"unknown"},{provide:Fo,deps:[Gr]},{provide:Ao,deps:[]},{provide:lo,deps:[]}]),$o=[{provide:Lo,useClass:Lo,deps:[wo,Gr,Cn,fs,eo]},{provide:Us,deps:[wo],useFactory:function(e){let t=[];return e.onStable.subscribe(()=>{for(;t.length;)t.pop()()}),function(e){t.push(e)}}},{provide:eo,useClass:eo,deps:[[new mn,Xs]]},{provide:go,useClass:go,deps:[]},no,{provide:Hs,useFactory:
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */
function(){return Vs},deps:[]},{provide:Rs,useFactory:function(){return Ls},deps:[]},{provide:uo,useFactory:function(e){return as(e=e||"undefined"!=typeof $localize&&$localize.locale||"en-US"),e},deps:[[new yn(uo),new mn,new gn]]},{provide:co,useValue:"USD"}];let zo=(()=>{class e{constructor(e){}}return e.\u0275fac=function(t){return new(t||e)(fn(Lo))},e.\u0275mod=Re({type:e}),e.\u0275inj=ne({providers:$o}),e})(),Uo=null;function Wo(){return Uo}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */const Go=new rn("DocumentToken");
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */var qo=function(e){return e[e.Zero=0]="Zero",e[e.One=1]="One",e[e.Two=2]="Two",e[e.Few=3]="Few",e[e.Many=4]="Many",e[e.Other=5]="Other",e}({});
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */class Qo{}let Jo=(()=>{class e extends Qo{constructor(e){super(),this.locale=e}getPluralCategory(e,t){switch(function(e){return function(e){const t=function(e){return e.toLowerCase().replace(/_/g,"-")}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */(e);let n=ls(t);if(n)return n;const r=t.split("-")[0];if(n=ls(r),n)return n;if("en"===r)return os;throw new Error(`Missing locale data for the locale "${e}".`)}(e)[us.PluralCase]}(t||this.locale)(e)){case qo.Zero:return"zero";case qo.One:return"one";case qo.Two:return"two";case qo.Few:return"few";case qo.Many:return"many";default:return"other"}}}return e.\u0275fac=function(t){return new(t||e)(fn(uo))},e.\u0275prov=te({token:e,factory:e.\u0275fac}),e})(),Ko=(()=>{class e{}return e.\u0275fac=function(t){return new(t||e)},e.\u0275mod=Re({type:e}),e.\u0275inj=ne({providers:[{provide:Qo,useClass:Jo}]}),e})();
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */class Yo extends
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */
/**
 * @license Angular v11.2.14
 * (c) 2010-2021 Google LLC. https://angular.io/
 * License: MIT
 */
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */
class extends class{}{constructor(){super()}supportsDOMEvents(){return!0}}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */{static makeCurrent(){var e;e=new Yo,Uo||(Uo=e)}getProperty(e,t){return e[t]}log(e){window.console&&window.console.log&&window.console.log(e)}logGroup(e){window.console&&window.console.group&&window.console.group(e)}logGroupEnd(){window.console&&window.console.groupEnd&&window.console.groupEnd()}onAndCancel(e,t,n){return e.addEventListener(t,n,!1),()=>{e.removeEventListener(t,n,!1)}}dispatchEvent(e,t){e.dispatchEvent(t)}remove(e){return e.parentNode&&e.parentNode.removeChild(e),e}getValue(e){return e.value}createElement(e,t){return(t=t||this.getDefaultDocument()).createElement(e)}createHtmlDocument(){return document.implementation.createHTMLDocument("fakeTitle")}getDefaultDocument(){return document}isElementNode(e){return e.nodeType===Node.ELEMENT_NODE}isShadowRoot(e){return e instanceof DocumentFragment}getGlobalEventTarget(e,t){return"window"===t?window:"document"===t?e:"body"===t?e.body:null}getHistory(){return window.history}getLocation(){return window.location}getBaseHref(e){const t=ei||(ei=document.querySelector("base"),ei)?ei.getAttribute("href"):null;return null==t?null:(n=t,Xo||(Xo=document.createElement("a")),Xo.setAttribute("href",n),"/"===Xo.pathname.charAt(0)?Xo.pathname:"/"+Xo.pathname);var n;
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */}resetBaseElement(){ei=null}getUserAgent(){return window.navigator.userAgent}performanceNow(){return window.performance&&window.performance.now?window.performance.now():(new Date).getTime()}supportsCookies(){return!0}getCookie(e){
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */
return function(e,t){t=encodeURIComponent(t);for(const n of e.split(";")){const e=n.indexOf("="),[r,s]=-1==e?[n,""]:[n.slice(0,e),n.slice(e+1)];if(r.trim()===t)return decodeURIComponent(s)}return null}(document.cookie,e)}}let Xo,ei=null;const ti=new rn("TRANSITION_ID"),ni=[{provide:Xs,useFactory:function(e,t,n){return()=>{n.get(eo).donePromise.then(()=>{const n=Wo();Array.prototype.slice.apply(t.querySelectorAll("style[ng-transition]")).filter(t=>t.getAttribute("ng-transition")===e).forEach(e=>n.remove(e))})}},deps:[ti,Go,Gr],multi:!0}];
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */class ri{static init(){var e;e=new ri,jo=e}addToWindow(e){we.getAngularTestability=(t,n=!0)=>{const r=e.findTestabilityInTree(t,n);if(null==r)throw new Error("Could not find testability for element.");return r},we.getAllAngularTestabilities=()=>e.getAllTestabilities(),we.getAllAngularRootElements=()=>e.getAllRootElements(),we.frameworkStabilizers||(we.frameworkStabilizers=[]),we.frameworkStabilizers.push(e=>{const t=we.getAllAngularTestabilities();let n=t.length,r=!1;const s=function(t){r=r||t,n--,0==n&&e(r)};t.forEach(function(e){e.whenStable(s)})})}findTestabilityInTree(e,t,n){if(null==t)return null;const r=e.getTestability(t);return null!=r?r:n?Wo().isShadowRoot(t)?this.findTestabilityInTree(e,t.host,!0):this.findTestabilityInTree(e,t.parentElement,!0):null}}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */const si=new rn("EventManagerPlugins");let oi=(()=>{class e{constructor(e,t){this._zone=t,this._eventNameToPlugin=new Map,e.forEach(e=>e.manager=this),this._plugins=e.slice().reverse()}addEventListener(e,t,n){return this._findPluginFor(t).addEventListener(e,t,n)}addGlobalEventListener(e,t,n){return this._findPluginFor(t).addGlobalEventListener(e,t,n)}getZone(){return this._zone}_findPluginFor(e){const t=this._eventNameToPlugin.get(e);if(t)return t;const n=this._plugins;for(let r=0;r<n.length;r++){const t=n[r];if(t.supports(e))return this._eventNameToPlugin.set(e,t),t}throw new Error(`No event manager plugin found for event ${e}`)}}return e.\u0275fac=function(t){return new(t||e)(fn(si),fn(wo))},e.\u0275prov=te({token:e,factory:e.\u0275fac}),e})();class ii{constructor(e){this._doc=e}addGlobalEventListener(e,t,n){const r=Wo().getGlobalEventTarget(this._doc,e);if(!r)throw new Error(`Unsupported event target ${r} for event ${t}`);return this.addEventListener(r,t,n)}}let li=(()=>{class e{constructor(){this._stylesSet=new Set}addStyles(e){const t=new Set;e.forEach(e=>{this._stylesSet.has(e)||(this._stylesSet.add(e),t.add(e))}),this.onStylesAdded(t)}onStylesAdded(e){}getAllStyles(){return Array.from(this._stylesSet)}}return e.\u0275fac=function(t){return new(t||e)},e.\u0275prov=te({token:e,factory:e.\u0275fac}),e})(),ui=(()=>{class e extends li{constructor(e){super(),this._doc=e,this._hostNodes=new Map,this._hostNodes.set(e.head,[])}_addStylesToHost(e,t,n){e.forEach(e=>{const r=this._doc.createElement("style");r.textContent=e,n.push(t.appendChild(r))})}addHost(e){const t=[];this._addStylesToHost(this._stylesSet,e,t),this._hostNodes.set(e,t)}removeHost(e){const t=this._hostNodes.get(e);t&&t.forEach(ci),this._hostNodes.delete(e)}onStylesAdded(e){this._hostNodes.forEach((t,n)=>{this._addStylesToHost(e,n,t)})}ngOnDestroy(){this._hostNodes.forEach(e=>e.forEach(ci))}}return e.\u0275fac=function(t){return new(t||e)(fn(Go))},e.\u0275prov=te({token:e,factory:e.\u0275fac}),e})();function ci(e){Wo().remove(e)}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */const ai={svg:"http://www.w3.org/2000/svg",xhtml:"http://www.w3.org/1999/xhtml",xlink:"http://www.w3.org/1999/xlink",xml:"http://www.w3.org/XML/1998/namespace",xmlns:"http://www.w3.org/2000/xmlns/"},hi=/%COMP%/g;function di(e,t,n){for(let r=0;r<t.length;r++){let s=t[r];Array.isArray(s)?di(e,s,n):(s=s.replace(hi,e),n.push(s))}return n}function fi(e){return t=>{if("__ngUnwrap__"===t)return e;!1===e(t)&&(t.preventDefault(),t.returnValue=!1)}}let pi=(()=>{class e{constructor(e,t,n){this.eventManager=e,this.sharedStylesHost=t,this.appId=n,this.rendererByCompId=new Map,this.defaultRenderer=new _i(e)}createRenderer(e,t){if(!e||!t)return this.defaultRenderer;switch(t.encapsulation){case ye.Emulated:{let n=this.rendererByCompId.get(t.id);return n||(n=new yi(this.eventManager,this.sharedStylesHost,t,this.appId),this.rendererByCompId.set(t.id,n)),n.applyToHost(e),n}case 1:case ye.ShadowDom:return new mi(this.eventManager,this.sharedStylesHost,e,t);default:if(!this.rendererByCompId.has(t.id)){const e=di(t.id,t.styles,[]);this.sharedStylesHost.addStyles(e),this.rendererByCompId.set(t.id,this.defaultRenderer)}return this.defaultRenderer}}begin(){}end(){}}return e.\u0275fac=function(t){return new(t||e)(fn(oi),fn(ui),fn(to))},e.\u0275prov=te({token:e,factory:e.\u0275fac}),e})();class _i{constructor(e){this.eventManager=e,this.data=Object.create(null)}destroy(){}createElement(e,t){return t?document.createElementNS(ai[t]||t,e):document.createElement(e)}createComment(e){return document.createComment(e)}createText(e){return document.createTextNode(e)}appendChild(e,t){e.appendChild(t)}insertBefore(e,t,n){e&&e.insertBefore(t,n)}removeChild(e,t){e&&e.removeChild(t)}selectRootElement(e,t){let n="string"==typeof e?document.querySelector(e):e;if(!n)throw new Error(`The selector "${e}" did not match any elements`);return t||(n.textContent=""),n}parentNode(e){return e.parentNode}nextSibling(e){return e.nextSibling}setAttribute(e,t,n,r){if(r){t=r+":"+t;const s=ai[r];s?e.setAttributeNS(s,t,n):e.setAttribute(t,n)}else e.setAttribute(t,n)}removeAttribute(e,t,n){if(n){const r=ai[n];r?e.removeAttributeNS(r,t):e.removeAttribute(`${n}:${t}`)}else e.removeAttribute(t)}addClass(e,t){e.classList.add(t)}removeClass(e,t){e.classList.remove(t)}setStyle(e,t,n,r){r&(Tn.DashCase|Tn.Important)?e.style.setProperty(t,n,r&Tn.Important?"important":""):e.style[t]=n}removeStyle(e,t,n){n&Tn.DashCase?e.style.removeProperty(t):e.style[t]=""}setProperty(e,t,n){e[t]=n}setValue(e,t){e.nodeValue=t}listen(e,t,n){return"string"==typeof e?this.eventManager.addGlobalEventListener(e,t,fi(n)):this.eventManager.addEventListener(e,t,fi(n))}}class yi extends _i{constructor(e,t,n,r){super(e),this.component=n;const s=di(r+"-"+n.id,n.styles,[]);t.addStyles(s),this.contentAttr="_ngcontent-%COMP%".replace(hi,r+"-"+n.id),this.hostAttr="_nghost-%COMP%".replace(hi,r+"-"+n.id)}applyToHost(e){super.setAttribute(e,this.hostAttr,"")}createElement(e,t){const n=super.createElement(e,t);return super.setAttribute(n,this.contentAttr,""),n}}class mi extends _i{constructor(e,t,n,r){super(e),this.sharedStylesHost=t,this.hostEl=n,this.shadowRoot=n.attachShadow({mode:"open"}),this.sharedStylesHost.addHost(this.shadowRoot);const s=di(r.id,r.styles,[]);for(let o=0;o<s.length;o++){const e=document.createElement("style");e.textContent=s[o],this.shadowRoot.appendChild(e)}}nodeOrShadowRoot(e){return e===this.hostEl?this.shadowRoot:e}destroy(){this.sharedStylesHost.removeHost(this.shadowRoot)}appendChild(e,t){return super.appendChild(this.nodeOrShadowRoot(e),t)}insertBefore(e,t,n){return super.insertBefore(this.nodeOrShadowRoot(e),t,n)}removeChild(e,t){return super.removeChild(this.nodeOrShadowRoot(e),t)}parentNode(e){return this.nodeOrShadowRoot(super.parentNode(this.nodeOrShadowRoot(e)))}}let gi=(()=>{class e extends ii{constructor(e){super(e)}supports(e){return!0}addEventListener(e,t,n){return e.addEventListener(t,n,!1),()=>this.removeEventListener(e,t,n)}removeEventListener(e,t,n){return e.removeEventListener(t,n)}}return e.\u0275fac=function(t){return new(t||e)(fn(Go))},e.\u0275prov=te({token:e,factory:e.\u0275fac}),e})();
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */const vi=["alt","control","meta","shift"],bi={"\b":"Backspace","\t":"Tab","\x7f":"Delete","\x1b":"Escape",Del:"Delete",Esc:"Escape",Left:"ArrowLeft",Right:"ArrowRight",Up:"ArrowUp",Down:"ArrowDown",Menu:"ContextMenu",Scroll:"ScrollLock",Win:"OS"},wi={A:"1",B:"2",C:"3",D:"4",E:"5",F:"6",G:"7",H:"8",I:"9",J:"*",K:"+",M:"-",N:".",O:"/","`":"0","\x90":"NumLock"},Ci={alt:e=>e.altKey,control:e=>e.ctrlKey,meta:e=>e.metaKey,shift:e=>e.shiftKey};let Ei=(()=>{class e extends ii{constructor(e){super(e)}supports(t){return null!=e.parseEventName(t)}addEventListener(t,n,r){const s=e.parseEventName(n),o=e.eventCallback(s.fullKey,r,this.manager.getZone());return this.manager.getZone().runOutsideAngular(()=>Wo().onAndCancel(t,s.domEventName,o))}static parseEventName(t){const n=t.toLowerCase().split("."),r=n.shift();if(0===n.length||"keydown"!==r&&"keyup"!==r)return null;const s=e._normalizeKey(n.pop());let o="";if(vi.forEach(e=>{const t=n.indexOf(e);t>-1&&(n.splice(t,1),o+=e+".")}),o+=s,0!=n.length||0===s.length)return null;const i={};return i.domEventName=r,i.fullKey=o,i}static getEventFullKey(e){let t="",n=function(e){let t=e.key;if(null==t){if(t=e.keyIdentifier,null==t)return"Unidentified";t.startsWith("U+")&&(t=String.fromCharCode(parseInt(t.substring(2),16)),3===e.location&&wi.hasOwnProperty(t)&&(t=wi[t]))}return bi[t]||t}(e);return n=n.toLowerCase()," "===n?n="space":"."===n&&(n="dot"),vi.forEach(r=>{r!=n&&(0,Ci[r])(e)&&(t+=r+".")}),t+=n,t}static eventCallback(t,n,r){return s=>{e.getEventFullKey(s)===t&&r.runGuarded(()=>n(s))}}static _normalizeKey(e){switch(e){case"esc":return"escape";default:return e}}}return e.\u0275fac=function(t){return new(t||e)(fn(Go))},e.\u0275prov=te({token:e,factory:e.\u0275fac}),e})();const xi=No(Bo,"browser",[{provide:oo,useValue:"browser"},{provide:so,useValue:
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */
function(){Yo.makeCurrent(),ri.init()},multi:!0},{provide:Go,useFactory:function(){return function(e){qe=e}(document),document},deps:[]}]),ki=[[],{provide:Pr,useValue:"root"},{provide:Cn,useFactory:function(){return new Cn},deps:[]},{provide:si,useClass:gi,multi:!0,deps:[Go,wo,oo]},{provide:si,useClass:Ei,multi:!0,deps:[Go]},[],{provide:pi,useClass:pi,deps:[oi,ui,to]},{provide:gs,useExisting:pi},{provide:li,useExisting:ui},{provide:ui,useClass:ui,deps:[Go]},{provide:Io,useClass:Io,deps:[wo]},{provide:oi,useClass:oi,deps:[si,wo]},[]];let Ti=(()=>{class e{constructor(e){if(e)throw new Error("BrowserModule has already been loaded. If you need access to common directives such as NgIf and NgFor from a lazy loaded module, import CommonModule instead.")}static withServerTransition(t){return{ngModule:e,providers:[{provide:to,useValue:t.appId},{provide:ti,useExisting:to},ni]}}}return e.\u0275fac=function(t){return new(t||e)(fn(e,12))},e.\u0275mod=Re({type:e}),e.\u0275inj=ne({providers:ki,imports:[Ko,zo]}),e})();"undefined"!=typeof window&&window;let Si=(()=>{class e{}return e.\u0275fac=function(t){return new(t||e)},e.\u0275mod=Re({type:e}),e.\u0275inj=ne({}),e})(),Ii=(()=>{class e{}return e.\u0275fac=function(t){return new(t||e)},e.\u0275mod=Re({type:e}),e.\u0275inj=ne({imports:[[Si]]}),e})(),Ai=(()=>{class e{}return e.\u0275fac=function(t){return new(t||e)},e.\u0275mod=Re({type:e}),e.\u0275inj=ne({imports:[Ii]}),e})(),Di=(()=>{class e{constructor(){this.name="Tom"}}return e.\u0275fac=function(t){return new(t||e)},e.\u0275cmp=(t={type:e,selectors:[["app"]],decls:4,vars:0,template:function(e,t){1&e&&(es(0,"h1"),rs(1,"Hello"),ts(),es(2,"div"),rs(3,"NEW WORLD!:)"),ts())},encapsulation:2},pe(()=>{const e={},n={type:t.type,providersResolver:null,decls:t.decls,vars:t.vars,factory:null,template:t.template||null,consts:t.consts||null,ngContentSelectors:t.ngContentSelectors,hostBindings:t.hostBindings||null,hostVars:t.hostVars||0,hostAttrs:t.hostAttrs||null,contentQueries:t.contentQueries||null,declaredInputs:e,inputs:null,outputs:null,exportAs:t.exportAs||null,onPush:t.changeDetection===_e.OnPush,directiveDefs:null,pipeDefs:null,selectors:t.selectors||Ee,viewQuery:t.viewQuery||null,features:t.features||null,data:t.data||{},encapsulation:t.encapsulation||ye.Emulated,id:"c",styles:t.styles||Ee,_:null,setInput:null,schemas:t.schemas||null,tView:null},r=t.directives,s=t.features,o=t.pipes;return n.id+=Oe++,n.inputs=Ne(t.inputs,e),n.outputs=Ne(t.outputs),s&&s.forEach(e=>e(n)),n.directiveDefs=r?()=>("function"==typeof r?r():r).map(je):null,n.pipeDefs=o?()=>("function"==typeof o?o():o).map(He):null,n})),e;var t})(),Oi=(()=>{class e{}return e.\u0275fac=function(t){return new(t||e)},e.\u0275mod=Re({type:e,bootstrap:[Di]}),e.\u0275inj=ne({imports:[[Ti,Ai]]}),e})();!function(){if(Po)throw new Error("Cannot enable prod mode after platform setup.");Ho=!1}
/**
 * @license
 * Copyright Google LLC All Rights Reserved.
 *
 * Use of this source code is governed by an MIT-style license that can be
 * found in the LICENSE file at https://angular.io/license
 */(),xi().bootstrapModule(Oi)},zn8P:function(e,t){function n(e){return Promise.resolve().then(function(){var t=new Error("Cannot find module '"+e+"'");throw t.code="MODULE_NOT_FOUND",t})}n.keys=function(){return[]},n.resolve=n,e.exports=n,n.id="zn8P"}},[[0,0]]]);