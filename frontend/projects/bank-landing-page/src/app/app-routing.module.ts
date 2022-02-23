import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
// import { AuthGuard } from '../../../../libs/auth/src/lib/guards/auth.guard';
import { ApplicationCalculatorComponent } from './components/application-calculator/application-calculator.component';
import { ApplicationCustomerAddressComponent } from './components/application-customer-address/application-customer-address.component';
import { ApplicationCustomerInfoComponent } from './components/application-customer-info/application-customer-info.component';
import { ApplicationDocumentsComponent } from './components/application-documents/application-documents.component';
import { ApplicationScoringResultComponent } from './components/application-scoring-result/application-scoring-result.component';
import { ApplicationSigningComponent } from './components/application-signing/application-signing.component';
import { CallbackSigninComponent } from './components/callback-signin/callback-signin.component';

const routes: Routes = [
  { path: '', redirectTo: '/finance', pathMatch: 'full' },
  { path: 'finance', component: ApplicationCalculatorComponent },
  { path: 'customer', component: ApplicationCustomerInfoComponent },
  { path: 'address', component: ApplicationCustomerAddressComponent },
  { path: 'verify', component: ApplicationScoringResultComponent },
  { path: 'documents', component: ApplicationDocumentsComponent },
  { path: 'complete', component: ApplicationSigningComponent },
  { path: 'callback-signin', component: CallbackSigninComponent }
  // { path: 'overview', component: BankingOverviewComponent, canActivate: [AuthGuard] }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
