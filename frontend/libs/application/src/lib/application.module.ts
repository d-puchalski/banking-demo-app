import { ModuleWithProviders, NgModule } from '@angular/core';
import { ApplicationService } from './services/application.service';

@NgModule({
  declarations: [
  ],
  imports: [
  ],
  exports: [
  ]
})
export class LibApplicationModule {
  public static forRoot(environment: any): ModuleWithProviders<LibApplicationModule> {
    return {
      ngModule: LibApplicationModule,
      providers: [
        ApplicationService,
        {
          provide: 'env',
          useValue: environment
        }
      ]
    };
  }
}
