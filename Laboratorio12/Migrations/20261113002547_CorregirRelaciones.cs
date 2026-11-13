using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Laboratorio12.Migrations
{
    /// <inheritdoc />
    public partial class CorregirRelaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Instructores_InstructorIdInstructor",
                table: "Cursos");

            migrationBuilder.DropForeignKey(
                name: "FK_Matriculas_Cursos_CursoIdCurso",
                table: "Matriculas");

            migrationBuilder.DropForeignKey(
                name: "FK_Matriculas_Estudiantes_EstudianteIdEstudiante",
                table: "Matriculas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Matriculas_MatriculaIdMatricula",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "IX_Pagos_MatriculaIdMatricula",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "IX_Matriculas_CursoIdCurso",
                table: "Matriculas");

            migrationBuilder.DropIndex(
                name: "IX_Matriculas_EstudianteIdEstudiante",
                table: "Matriculas");

            migrationBuilder.DropIndex(
                name: "IX_Cursos_InstructorIdInstructor",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "MatriculaIdMatricula",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "CursoIdCurso",
                table: "Matriculas");

            migrationBuilder.DropColumn(
                name: "EstudianteIdEstudiante",
                table: "Matriculas");

            migrationBuilder.DropColumn(
                name: "InstructorIdInstructor",
                table: "Cursos");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_IdMatricula",
                table: "Pagos",
                column: "IdMatricula");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_IdCurso",
                table: "Matriculas",
                column: "IdCurso");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_IdEstudiante",
                table: "Matriculas",
                column: "IdEstudiante");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_IdInstructor",
                table: "Cursos",
                column: "IdInstructor");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Instructores_IdInstructor",
                table: "Cursos",
                column: "IdInstructor",
                principalTable: "Instructores",
                principalColumn: "IdInstructor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Matriculas_Cursos_IdCurso",
                table: "Matriculas",
                column: "IdCurso",
                principalTable: "Cursos",
                principalColumn: "IdCurso",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Matriculas_Estudiantes_IdEstudiante",
                table: "Matriculas",
                column: "IdEstudiante",
                principalTable: "Estudiantes",
                principalColumn: "IdEstudiante",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Matriculas_IdMatricula",
                table: "Pagos",
                column: "IdMatricula",
                principalTable: "Matriculas",
                principalColumn: "IdMatricula",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Instructores_IdInstructor",
                table: "Cursos");

            migrationBuilder.DropForeignKey(
                name: "FK_Matriculas_Cursos_IdCurso",
                table: "Matriculas");

            migrationBuilder.DropForeignKey(
                name: "FK_Matriculas_Estudiantes_IdEstudiante",
                table: "Matriculas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Matriculas_IdMatricula",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "IX_Pagos_IdMatricula",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "IX_Matriculas_IdCurso",
                table: "Matriculas");

            migrationBuilder.DropIndex(
                name: "IX_Matriculas_IdEstudiante",
                table: "Matriculas");

            migrationBuilder.DropIndex(
                name: "IX_Cursos_IdInstructor",
                table: "Cursos");

            migrationBuilder.AddColumn<int>(
                name: "MatriculaIdMatricula",
                table: "Pagos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CursoIdCurso",
                table: "Matriculas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EstudianteIdEstudiante",
                table: "Matriculas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InstructorIdInstructor",
                table: "Cursos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_MatriculaIdMatricula",
                table: "Pagos",
                column: "MatriculaIdMatricula");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_CursoIdCurso",
                table: "Matriculas",
                column: "CursoIdCurso");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_EstudianteIdEstudiante",
                table: "Matriculas",
                column: "EstudianteIdEstudiante");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_InstructorIdInstructor",
                table: "Cursos",
                column: "InstructorIdInstructor");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Instructores_InstructorIdInstructor",
                table: "Cursos",
                column: "InstructorIdInstructor",
                principalTable: "Instructores",
                principalColumn: "IdInstructor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Matriculas_Cursos_CursoIdCurso",
                table: "Matriculas",
                column: "CursoIdCurso",
                principalTable: "Cursos",
                principalColumn: "IdCurso",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Matriculas_Estudiantes_EstudianteIdEstudiante",
                table: "Matriculas",
                column: "EstudianteIdEstudiante",
                principalTable: "Estudiantes",
                principalColumn: "IdEstudiante",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Matriculas_MatriculaIdMatricula",
                table: "Pagos",
                column: "MatriculaIdMatricula",
                principalTable: "Matriculas",
                principalColumn: "IdMatricula",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
