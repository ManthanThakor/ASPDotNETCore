using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class AuthenticationController : Controller
    {
        // 1. IActionResult
        public IActionResult Login()
        {
            return View(); // Renders the default Login view
        }

        // 2. ActionResult<T>
        public ActionResult<string> WelcomeMessage()
        {
            return "Welcome to the Login Page"; // Returns a plain string
        }

        // 3. ViewResult
        public ViewResult CustomLogin()
        {
            return View("CustomLogin"); // Renders a specific view named "CustomLogin"
        }

        // 4. JsonResult
        public JsonResult LoginStatus()
        {
            return Json(new { message = "Login successful", status = true });
        }

        // 5. ContentResult
        public ContentResult PlainTextMessage()
        {
            return Content("This is the Login Page", "text/plain");
        }

        // 6. RedirectResult
        public RedirectResult RedirectToExternalLogin()
        {
            return Redirect("https://example.com/login");
        }

        // 7. RedirectToActionResult
        public RedirectToActionResult RedirectToHome()
        {
            return RedirectToAction("Index", "Home"); // Redirects to HomeController's Index action
        }

        // 8. FileResult
        public FileResult DownloadLoginGuide()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes("wwwroot/sample.pdf");
            return File(fileBytes, "application/pdf", "LoginGuide.pdf");
        }

        // 9. StatusCodeResult
        public StatusCodeResult AccessDenied()
        {
            return StatusCode(403); // Forbidden
        }

        // 10. NoContentResult
        public NoContentResult NoContentResponse()
        {
            return NoContent();
        }

        // 11. BadRequestResult and BadRequest<T>
        public BadRequestResult InvalidRequest()
        {
            return BadRequest();
        }

        public BadRequest<string> InvalidRequestWithDetails()
        {
            return BadRequest("Invalid login credentials");
        }

        // 12. NotFoundResult and NotFound<T>
        public NotFoundResult PageNotFound()
        {
            return NotFound();
        }

        public NotFound<string> PageNotFoundWithDetails()
        {
            return NotFound("The requested login page was not found");
        }

        // 13. OkResult and Ok<T>
        public OkResult SuccessfulLogin()
        {
            return Ok();
        }

        public Ok<string> SuccessfulLoginMessage()
        {
            return Ok("Login succeeded");
        }

        // 14. UnauthorizedResult
        public UnauthorizedResult UnauthorizedAccess()
        {
            return Unauthorized();
        }
    }
}
