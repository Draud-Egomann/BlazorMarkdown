using Markdig;

namespace Data.Services;

public class MarkdownService {
  public string RenderMarkdown(string markdown) {
    if (string.IsNullOrWhiteSpace(markdown))
      return string.Empty;

    var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
    return Markdown.ToHtml(markdown, pipeline);
  }

  public string GetMarkdownContent(string path) {
    if (string.IsNullOrWhiteSpace(path))
      return string.Empty;

    try {
      path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", path);

      var content = File.ReadAllText(path);
      return RenderMarkdown(content);
    } catch (Exception ex) {
      return $"<p class=\"text-danger\">Error loading markdown file: {ex.Message}</p>";
    }
  }
}
