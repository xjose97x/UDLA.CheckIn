import { Component } from '@angular/core';

@Component({
  selector: 'ngx-footer',
  styleUrls: ['./footer.component.scss'],
  template: `
    <span class="created-by">Creado con ♥ por José I. Escudero © 2018</span>
    <div class="socials">
      <a href="https://github.com/xjose97x" target="_blank" class="ion ion-social-github"></a>
      <a href="https://www.facebook.com/UDLAQuito" target="_blank" class="ion ion-social-facebook"></a>
      <a href="https://twitter.com/UDLAQuito" target="_blank" class="ion ion-social-twitter"></a>
      <a href="https://www.linkedin.com/company/universidad-de-las-am-ricas-udla-ecuador-" target="_blank" class="ion ion-social-linkedin"></a>
    </div>
  `,
})
export class FooterComponent {
}
