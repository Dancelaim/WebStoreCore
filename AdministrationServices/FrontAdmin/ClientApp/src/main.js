"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var platform_browser_dynamic_1 = require("@angular/platform-browser-dynamic");
var core_1 = require("@angular/core");
var app_module_1 = require("./app/app.module");
(0, core_1.enableProdMode)();
var platform = (0, platform_browser_dynamic_1.platformBrowserDynamic)();
platform.bootstrapModule(app_module_1.AppModule);
//# sourceMappingURL=main.js.map