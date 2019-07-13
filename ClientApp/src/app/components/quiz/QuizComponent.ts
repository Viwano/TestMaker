import { Component, Input } from "@angular/core";

@Component({
selector: "quiz",
templateUrl: './QuizComponent.html',
styleUrls: ['./QuizComponent.css']
})

export class QuizComponent {
@Input() quiz: Quiz;
}
