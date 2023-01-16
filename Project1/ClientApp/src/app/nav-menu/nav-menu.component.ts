import { Component } from '@angular/core';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  toggleProfileDropdown() {
    var profile_dropdown = document.getElementById("profile-dropdown") as HTMLDivElement;
    if(profile_dropdown.getAttributeNames().find(element => element === "close") !== undefined){
      profile_dropdown.removeAttribute("close");
      profile_dropdown.setAttribute("open","open");
    } else {
      profile_dropdown.removeAttribute("open");
      profile_dropdown.setAttribute("close","close");
    }
  }


}
