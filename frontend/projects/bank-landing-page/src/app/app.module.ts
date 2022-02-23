import { HttpClientModule } from '@angular/common/http';
import { ApplicationModule, NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ApplicationCalculatorComponent } from './components/application-calculator/application-calculator.component';
import { ApplicationDocumentsComponent } from './components/application-documents/application-documents.component';
import { ApplicationScoringResultComponent } from './components/application-scoring-result/application-scoring-result.component';
import { CallbackSigninComponent } from './components/callback-signin/callback-signin.component';
import { UiFooterComponent } from './components/ui-footer/ui-footer.component';
import { UiHeaderComponent } from './components/ui-header/ui-header.component';
import { UiPreloaderComponent } from './components/ui-preloader/ui-preloader.component';
import { ApplicationCustomerInfoComponent } from './components/application-customer-info/application-customer-info.component';
import { ApplicationCustomerAddressComponent } from './components/application-customer-address/application-customer-address.component';
import { LibApplicationModule } from '../../../../libs/application/src/lib/application.module';
import { environment } from '../environments/environment';

@NgModule({
  declarations: [
    AppComponent,
    ApplicationCalculatorComponent,
    ApplicationScoringResultComponent,
    ApplicationDocumentsComponent,
    UiFooterComponent,
    UiHeaderComponent,
    UiPreloaderComponent,
    CallbackSigninComponent,
    ApplicationCustomerInfoComponent,
    ApplicationCustomerAddressComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    ApplicationModule,
    FormsModule,
    ReactiveFormsModule,
    LibApplicationModule.forRoot(environment)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
